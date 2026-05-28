namespace DevExpress.MVVM.Demos.Navigation {
    partial class DocumentManagerModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentManagerModule));
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.biCategories = new DevExpress.XtraBars.BarButtonItem();
            this.biTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.sourceCode = new DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            //
            this.tabbedView.Padding = new System.Windows.Forms.Padding(16);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.ExpensesDbContextViewModel);
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
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
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
            this.biAccounts.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.currency;
            this.biAccounts.Name = "biAccounts";
            // 
            // biCategories
            // 
            this.biCategories.Caption = "Categories";
            this.biCategories.Id = 2;
            this.biCategories.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.pieseries;
            this.biCategories.Name = "biCategories";
            // 
            // biTransactions
            // 
            this.biTransactions.Caption = "Transactions";
            this.biTransactions.Id = 3;
            this.biTransactions.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Transactions;
            this.biTransactions.Name = "biTransactions";
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
            // sourceCode
            // 
            this.sourceCode.CurrentNestedType = null;
            this.sourceCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sourceCode.Location = new System.Drawing.Point(5, 180);
            this.sourceCode.Margin = new System.Windows.Forms.Padding(0);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.Padding = new System.Windows.Forms.Padding(16, 0, 16, 16);
            this.sourceCode.RichText = "";
            this.sourceCode.Size = new System.Drawing.Size(795, 215);
            this.sourceCode.TabIndex = 6;
            // 
            // DocumentManagerModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.sourceCode);
            this.Name = "DocumentManagerModule";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.Docking2010.DocumentManager documentManager;
        private XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.BarButtonItem biAccounts;
        private XtraBars.BarButtonItem biCategories;
        private XtraBars.BarButtonItem biTransactions;
        private DXperience.Demos.CodeDemo.RichEditUserControl sourceCode;
    }
}
