namespace DevExpress.XtraMap.Demos {
    partial class WebMapService {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.WmsLayer = new DevExpress.XtraMap.ImageLayer();
            this.Provider = new DevExpress.XtraMap.WmsDataProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.editWebMapSevice = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // WmsLayer
            // 
            this.WmsLayer.DataProvider = this.Provider;
            this.WmsLayer.Name = "WmsLayer";
            // 
            // Provider
            // 
            this.Provider.ServerUri = "http://ows.mundialis.de/services/service";
            this.Provider.ResponseCapabilities += new DevExpress.XtraMap.CapabilitiesRespondedEventHandler(this.OnResponseCapabilities);
            // 
            // mapControl1
            // 
            this.mapControl1.BackColor = System.Drawing.Color.LightBlue;
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(34.5D, -91.5D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableRotation = false;
            this.mapControl1.Layers.Add(this.WmsLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 139);
            this.mapControl1.MaxZoomLevel = 8D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(500, 361);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 4D;
            this.mapControl1.OverlaysArranged += new DevExpress.XtraMap.OverlaysArrangedEventHandler(this.OnOverlaysArranged);
            this.mapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMapControlMouseUp);
            // 
            // editWebMapSevice
            // 
            this.editWebMapSevice.Edit = this.repositoryItemComboBox1;
            this.editWebMapSevice.EditWidth = 120;
            this.editWebMapSevice.Id = 1;
            this.editWebMapSevice.Name = "editWebMapSevice";
            this.editWebMapSevice.EditValueChanged += new System.EventHandler(this.editWebMapSevice_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Options";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.editWebMapSevice);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Web Map Service";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // WebMapService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.panelControl1.Controls.Add(this.mapControl1);
            this.Name = "WebMapService";
            this.panelControl1.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private ImageLayer WmsLayer;
        private WmsDataProvider Provider;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.BarEditItem editWebMapSevice;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
