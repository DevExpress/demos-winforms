namespace DevExpress.SalesDemo.Win {
    partial class MainForm {
        
        
        
        private System.ComponentModel.IContainer components = null;

        
        
        
        
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        
        
        
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.windowsUIView = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.hubGroup = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup(this.components);
            this.documentSalesDashboard = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentProducts = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentSectors = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentRegions = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.documentChannels = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.loginFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.documentLoginPage = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.closeFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hubGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSalesDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentChannels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFlyout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentLoginPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeFlyout)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.barManager;
            this.documentManager.View = this.windowsUIView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView});
            
            
            
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.MaxItemId = 0;
            
            
            
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1264, 0);
            
            
            
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 761);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1264, 0);
            
            
            
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 761);
            
            
            
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1264, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 761);
            
            
            
            this.windowsUIView.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.windowsUIView.AppearanceCaption.Options.UseFont = true;
            this.windowsUIView.BackgroundImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.BottomLeft;
            this.windowsUIView.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.hubGroup,
            this.closeFlyout,
            this.loginFlyout});
            this.windowsUIView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.documentSalesDashboard,
            this.documentProducts,
            this.documentSectors,
            this.documentRegions,
            this.documentChannels,
            this.documentLoginPage});
            this.windowsUIView.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False;
            this.windowsUIView.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView_QueryControl);
            
            
            
            this.hubGroup.AppearanceHeaderButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.hubGroup.AppearanceHeaderButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.hubGroup.AppearanceHeaderButton.Hovered.Options.UseBackColor = true;
            this.hubGroup.AppearanceHeaderButton.Hovered.Options.UseForeColor = true;
            this.hubGroup.AppearanceHeaderButton.Hovered.Options.UseTextOptions = true;
            this.hubGroup.AppearanceHeaderButton.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.hubGroup.AppearanceHeaderButton.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(158)))), ((int)(((byte)(165)))));
            this.hubGroup.AppearanceHeaderButton.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hubGroup.AppearanceHeaderButton.Normal.Options.UseBackColor = true;
            this.hubGroup.AppearanceHeaderButton.Normal.Options.UseForeColor = true;
            this.hubGroup.AppearanceHeaderButton.Normal.Options.UseTextOptions = true;
            this.hubGroup.AppearanceHeaderButton.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.hubGroup.AppearanceHeaderButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.hubGroup.AppearanceHeaderButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hubGroup.AppearanceHeaderButton.Pressed.Options.UseBackColor = true;
            this.hubGroup.AppearanceHeaderButton.Pressed.Options.UseForeColor = true;
            this.hubGroup.AppearanceHeaderButton.Pressed.Options.UseTextOptions = true;
            this.hubGroup.AppearanceHeaderButton.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.hubGroup.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.documentSalesDashboard,
            this.documentProducts,
            this.documentSectors,
            this.documentRegions,
            this.documentChannels});
            this.hubGroup.Name = "hubGroup";
            this.hubGroup.Parent = this.loginFlyout;
            this.hubGroup.Properties.AllowHtmlDrawHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.hubGroup.Properties.HeaderOffset = -12;
            this.hubGroup.Properties.HeaderStyle = DevExpress.XtraBars.Docking2010.Views.WindowsUI.HeaderStyle.Tile;
            this.hubGroup.Properties.Margin = new System.Windows.Forms.Padding(-8, -56, 10, 30);
            this.hubGroup.Properties.TileSize = 140;
            
            
            
            this.documentSalesDashboard.Caption = "Sales Dashboard";
            this.documentSalesDashboard.ControlName = "ucSalesDashboard";
            this.documentSalesDashboard.ControlTypeName = "DevExpress.SalesDemo.Win.Modules.ucSalesDashboard";
            this.documentSalesDashboard.Header = "<size=16>Sales</size><br><size=8>Revenue<br>Snapshot</size>";
            
            
            
            this.documentProducts.Caption = "Products";
            this.documentProducts.ControlName = "ucProducts";
            this.documentProducts.ControlTypeName = "DevExpress.SalesDemo.Win.Modules.ucProducts";
            this.documentProducts.Header = "<size=16>Products</size><br><size=8>Revenue<br>by Products</size>";
            
            
            
            this.documentSectors.Caption = "Sectors";
            this.documentSectors.ControlName = "ucSectors";
            this.documentSectors.ControlTypeName = "DevExpress.SalesDemo.Win.Modules.ucSectors";
            this.documentSectors.Header = "<size=16>Sectors</size><br><size=8>Revenue<br>by Sectors</size>";
            
            
            
            this.documentRegions.Caption = "Regions";
            this.documentRegions.ControlName = "ucRegions";
            this.documentRegions.ControlTypeName = "DevExpress.SalesDemo.Win.Modules.ucRegions";
            this.documentRegions.Header = "<size=16>Regions</size><br><size=8>Revenue<br>by Regions</size>";
            
            
            
            this.documentChannels.Caption = "Channels";
            this.documentChannels.ControlName = "ucChannels";
            this.documentChannels.ControlTypeName = "DevExpress.SalesDemo.Win.Modules.ucChannels";
            this.documentChannels.Header = "<size=16>Channels</size><br><size=8>Revenue<br>by Sales Channels</size>";
            
            
            
            this.loginFlyout.Document = this.documentLoginPage;
            this.loginFlyout.Name = "loginFlyout";
            
            
            
            this.documentLoginPage.Caption = "Login Page";
            this.documentLoginPage.ControlName = "ucLoginPage";
            this.documentLoginPage.ControlTypeName = "DevExpress.SalesDemo.Win.Modules.ucLoginPage";
            
            
            
            this.closeFlyout.Name = "closeFlyout";
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1274, 793);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALES & REVENUE DASHBOARD";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hubGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSalesDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentSectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentChannels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginFlyout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentLoginPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeFlyout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.Docking2010.DocumentManager documentManager;
        private XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView;
        private XtraBars.Docking2010.Views.WindowsUI.TabbedGroup hubGroup;
        private XtraBars.Docking2010.Views.WindowsUI.Document documentSalesDashboard;
        private XtraBars.Docking2010.Views.WindowsUI.Document documentProducts;
        private XtraBars.Docking2010.Views.WindowsUI.Document documentSectors;
        private XtraBars.Docking2010.Views.WindowsUI.Document documentRegions;
        private XtraBars.Docking2010.Views.WindowsUI.Document documentChannels;
        private XtraBars.BarManager barManager;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.Docking2010.Views.WindowsUI.Flyout closeFlyout;
        private XtraBars.Docking2010.Views.WindowsUI.Document documentLoginPage;
        private XtraBars.Docking2010.Views.WindowsUI.Flyout loginFlyout;
    }
}
