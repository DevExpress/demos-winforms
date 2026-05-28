namespace DevExpress.Xpo.Demos {
    partial class DataCaching {
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
            this.gclDataCachingMain = new DevExpress.XtraGrid.GridControl();
            this.gvlDataCaching = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbChangeAnyEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.lbSelectCount = new DevExpress.XtraEditors.LabelControl();
            this.sbOrders = new DevExpress.XtraEditors.SimpleButton();
            this.sbEmployees = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gclDataCachingMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlDataCaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gclDataCachingMain
            // 
            this.gclDataCachingMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclDataCachingMain.Location = new System.Drawing.Point(0, 48);
            this.gclDataCachingMain.MainView = this.gvlDataCaching;
            this.gclDataCachingMain.Name = "gclDataCachingMain";
            this.gclDataCachingMain.Size = new System.Drawing.Size(784, 476);
            this.gclDataCachingMain.TabIndex = 2;
            this.gclDataCachingMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlDataCaching});
            // 
            // gvlDataCaching
            // 
            this.gvlDataCaching.GridControl = this.gclDataCachingMain;
            this.gvlDataCaching.Name = "gvlDataCaching";
            this.gvlDataCaching.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbChangeAnyEmployee);
            this.panelControl1.Controls.Add(this.lbSelectCount);
            this.panelControl1.Controls.Add(this.sbOrders);
            this.panelControl1.Controls.Add(this.sbEmployees);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 48);
            this.panelControl1.TabIndex = 3;
            // 
            // sbChangeAnyEmployee
            // 
            this.sbChangeAnyEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbChangeAnyEmployee.Location = new System.Drawing.Point(352, 12);
            this.sbChangeAnyEmployee.Name = "sbChangeAnyEmployee";
            this.sbChangeAnyEmployee.Size = new System.Drawing.Size(137, 21);
            this.sbChangeAnyEmployee.TabIndex = 9;
            this.sbChangeAnyEmployee.Text = "Change Employee Data";
            this.sbChangeAnyEmployee.Click += new System.EventHandler(this.changeAnyEmployee_Click);
            // 
            // lbSelectCount
            // 
            this.lbSelectCount.Location = new System.Drawing.Point(186, 17);
            this.lbSelectCount.Name = "lbSelectCount";
            this.lbSelectCount.Size = new System.Drawing.Size(6, 13);
            this.lbSelectCount.TabIndex = 8;
            this.lbSelectCount.Text = "0";
            // 
            // sbOrders
            // 
            this.sbOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbOrders.Location = new System.Drawing.Point(650, 12);
            this.sbOrders.Name = "sbOrders";
            this.sbOrders.Size = new System.Drawing.Size(120, 21);
            this.sbOrders.TabIndex = 7;
            this.sbOrders.Text = "Load Orders";
            this.sbOrders.Click += new System.EventHandler(this.sbOrders_Click);
            // 
            // sbEmployees
            // 
            this.sbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbEmployees.Location = new System.Drawing.Point(524, 12);
            this.sbEmployees.Name = "sbEmployees";
            this.sbEmployees.Size = new System.Drawing.Size(120, 21);
            this.sbEmployees.TabIndex = 6;
            this.sbEmployees.Text = "Load Employees";
            this.sbEmployees.Click += new System.EventHandler(this.sbEmployees_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(161, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Requests passed to a data store:";
            // 
            // DataCaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gclDataCachingMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "DataCaching";
            this.Size = new System.Drawing.Size(784, 524);
            //this.TutorialInfo.AboutFile = null;
            //this.TutorialInfo.Description = null;
            //this.TutorialInfo.TutorialName = null;
            //this.TutorialInfo.WhatsThisCodeFile = null;
            //this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.gclDataCachingMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlDataCaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclDataCachingMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlDataCaching;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbEmployees;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbOrders;
        private DevExpress.XtraEditors.LabelControl lbSelectCount;
        private DevExpress.XtraEditors.SimpleButton sbChangeAnyEmployee;
    }
}
