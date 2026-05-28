namespace DevExpress.Xpo.Demos {
    partial class ObjectLayerServices {
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
            this.gclObjectLayerServicesMain = new DevExpress.XtraGrid.GridControl();
            this.gvlObjectLayerServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbStartService = new DevExpress.XtraEditors.SimpleButton();
            this.sbEmployees = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gclObjectLayerServicesMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlObjectLayerServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gclObjectLayerServicesMain
            // 
            this.gclObjectLayerServicesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclObjectLayerServicesMain.Location = new System.Drawing.Point(0, 59);
            this.gclObjectLayerServicesMain.MainView = this.gvlObjectLayerServices;
            this.gclObjectLayerServicesMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gclObjectLayerServicesMain.Name = "gclObjectLayerServicesMain";
            this.gclObjectLayerServicesMain.Size = new System.Drawing.Size(915, 586);
            this.gclObjectLayerServicesMain.TabIndex = 2;
            this.gclObjectLayerServicesMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlObjectLayerServices});
            // 
            // gvlObjectLayerServices
            // 
            this.gvlObjectLayerServices.GridControl = this.gclObjectLayerServicesMain;
            this.gvlObjectLayerServices.Name = "gvlObjectLayerServices";
            this.gvlObjectLayerServices.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbStartService);
            this.panelControl1.Controls.Add(this.sbEmployees);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(915, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // sbStartService
            // 
            this.sbStartService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbStartService.Location = new System.Drawing.Point(681, 15);
            this.sbStartService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbStartService.Name = "sbStartService";
            this.sbStartService.Size = new System.Drawing.Size(215, 26);
            this.sbStartService.TabIndex = 7;
            this.sbStartService.Text = "Start Service and Create Client";
            this.sbStartService.Click += new System.EventHandler(this.sbStartService_Click);
            // 
            // sbEmployees
            // 
            this.sbEmployees.Enabled = false;
            this.sbEmployees.Location = new System.Drawing.Point(20, 15);
            this.sbEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbEmployees.Name = "sbEmployees";
            this.sbEmployees.Size = new System.Drawing.Size(262, 26);
            this.sbEmployees.TabIndex = 6;
            this.sbEmployees.Text = "Load Employees via WCF Service";
            this.sbEmployees.Click += new System.EventHandler(this.sbEmployees_Click);
            // 
            // ObjectLayerServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gclObjectLayerServicesMain);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ObjectLayerServices";
            this.Size = new System.Drawing.Size(915, 645);
            ((System.ComponentModel.ISupportInitialize)(this.gclObjectLayerServicesMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlObjectLayerServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclObjectLayerServicesMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlObjectLayerServices;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbEmployees;
        private DevExpress.XtraEditors.SimpleButton sbStartService;
    }
}
