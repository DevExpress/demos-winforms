namespace DevExpress.MVVM.Demos.Navigation {
    partial class TabControlModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControlModule));
            this.xtraScrollableControl = new XtraEditors.XtraScrollableControl();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.biCategories = new DevExpress.XtraBars.BarButtonItem();
            this.biTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.sourceCode = new DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.biAccounts,
            this.biCategories,
            this.biTransactions});
            this.ribbonControl.Location = new System.Drawing.Point(5, 0);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(795, 116);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // biAccounts
            // 
            this.biAccounts.Caption = "Accounts";
            this.biAccounts.Id = 1;
            this.biAccounts.Name = "biAccounts";
            this.biAccounts.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.currency;
            // 
            // biCategories
            // 
            this.biCategories.Caption = "Categories";
            this.biCategories.Id = 2;
            this.biCategories.Name = "biCategories";
            this.biCategories.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.pieseries;
            // 
            // biTransactions
            // 
            this.biTransactions.Caption = "Transactions";
            this.biTransactions.Id = 3;
            this.biTransactions.Name = "biTransactions";
            this.biTransactions.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Transactions;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "EXPENSES";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.biAccounts);
            this.ribbonPageGroup1.ItemLinks.Add(this.biCategories);
            this.ribbonPageGroup1.ItemLinks.Add(this.biTransactions);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Navigation";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(5, 116);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.Size = new System.Drawing.Size(795, 64);
            this.xtraTabControl.TabIndex = 1;
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            // 
            // xtraScrollableControl
            // 
            this.xtraScrollableControl.Controls.Add(this.xtraTabControl);
            this.xtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl.Padding = new System.Windows.Forms.Padding(16, 16, 16, 0);
            this.xtraScrollableControl.Size = new System.Drawing.Size(800, 64);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.ExpensesDbContextViewModel);
            // 
            // sourceCode
            // 
            this.sourceCode.CurrentNestedType = null;
            this.sourceCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sourceCode.Location = new System.Drawing.Point(5, 180);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.Padding = new System.Windows.Forms.Padding(16);
            this.sourceCode.RichText = "";
            this.sourceCode.Size = new System.Drawing.Size(795, 215);
            this.sourceCode.TabIndex = 7;
            // 
            // TabControlModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraScrollableControl);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.sourceCode);
            this.Name = "TabControlModule";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraEditors.XtraScrollableControl xtraScrollableControl;
        private XtraBars.BarButtonItem biAccounts;
        private XtraBars.BarButtonItem biCategories;
        private XtraBars.BarButtonItem biTransactions;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraTab.XtraTabControl xtraTabControl;
        private Utils.MVVM.MVVMContext mvvmContext;
        private DXperience.Demos.CodeDemo.RichEditUserControl sourceCode;
    }
}
