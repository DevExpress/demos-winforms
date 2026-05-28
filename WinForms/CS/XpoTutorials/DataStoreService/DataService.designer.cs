namespace DevExpress.Xpo.Demos {
    partial class DataServices {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gclDataServicesMain = new DevExpress.XtraGrid.GridControl();
            this.gvlDataServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbStartService = new DevExpress.XtraEditors.SimpleButton();
            this.sbEmployees = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gclDataServicesMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlDataServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gclDataServicesMain
            // 
            this.gclDataServicesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclDataServicesMain.Location = new System.Drawing.Point(0, 48);
            this.gclDataServicesMain.MainView = this.gvlDataServices;
            this.gclDataServicesMain.Name = "gclDataServicesMain";
            this.gclDataServicesMain.Size = new System.Drawing.Size(784, 476);
            this.gclDataServicesMain.TabIndex = 2;
            this.gclDataServicesMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlDataServices});
            // 
            // gvlDataServices
            // 
            this.gvlDataServices.GridControl = this.gclDataServicesMain;
            this.gvlDataServices.Name = "gvlDataServices";
            this.gvlDataServices.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbStartService);
            this.panelControl1.Controls.Add(this.sbEmployees);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 48);
            this.panelControl1.TabIndex = 3;
            // 
            // sbStartService
            // 
            this.sbStartService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbStartService.Location = new System.Drawing.Point(584, 12);
            this.sbStartService.Name = "sbStartService";
            this.sbStartService.Size = new System.Drawing.Size(184, 21);
            this.sbStartService.TabIndex = 7;
            this.sbStartService.Text = "Start Service and Create Client";
            this.sbStartService.Click += new System.EventHandler(this.sbStartService_Click);
            // 
            // sbEmployees
            // 
            this.sbEmployees.Enabled = false;
            this.sbEmployees.Location = new System.Drawing.Point(17, 12);
            this.sbEmployees.Name = "sbEmployees";
            this.sbEmployees.Size = new System.Drawing.Size(225, 21);
            this.sbEmployees.TabIndex = 6;
            this.sbEmployees.Text = "Load Employees via WCF Service";
            this.sbEmployees.Click += new System.EventHandler(this.sbEmployees_Click);
            // 
            // DataServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gclDataServicesMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "DataServices";
            this.Size = new System.Drawing.Size(784, 524);
            //this.TutorialInfo.AboutFile = null;
            //this.TutorialInfo.Description = null;
            //this.TutorialInfo.TutorialName = null;
            //this.TutorialInfo.WhatsThisCodeFile = null;
            //this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.gclDataServicesMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlDataServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclDataServicesMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlDataServices;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbEmployees;
        private DevExpress.XtraEditors.SimpleButton sbStartService;
    }
}
