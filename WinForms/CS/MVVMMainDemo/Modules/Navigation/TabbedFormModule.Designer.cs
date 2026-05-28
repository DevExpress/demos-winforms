namespace DevExpress.MVVM.Demos.Navigation {
    partial class TabbedFormModule {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabbedFormModule));
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.tabFormControl = new DevExpress.XtraBars.TabFormControl();
            this.biAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.biCategories = new DevExpress.XtraBars.BarButtonItem();
            this.biTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.ExpensesDbContextViewModel);
            // 
            // tabFormControl
            // 
            this.tabFormControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.biAccounts,
            this.biCategories,
            this.biTransactions});
            this.tabFormControl.LinkProvider.TabLeftItemLinks.Add(this.biAccounts);
            this.tabFormControl.LinkProvider.TabLeftItemLinks.Add(this.biCategories);
            this.tabFormControl.LinkProvider.TabLeftItemLinks.Add(this.biTransactions);
            this.tabFormControl.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl.Manager = this.tabFormDefaultManager1;
            this.tabFormControl.Name = "tabFormControl";
            this.tabFormControl.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.True;
            this.tabFormControl.Size = new System.Drawing.Size(950, 25);
            this.tabFormControl.TabForm = this;
            this.tabFormControl.TabIndex = 8;
            this.tabFormControl.TabStop = false;
            this.tabFormControl.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.tabFormControl_OuterFormCreating);
            this.tabFormControl.PageClosed += new DevExpress.XtraBars.PageClosedEventHandler(this.tabFormControl_PageClosed);
            // 
            // biAccounts
            // 
            this.biAccounts.Caption = "Accounts";
            this.biAccounts.Id = 0;
            this.biAccounts.Name = "biAccounts";
            this.biAccounts.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.currency;
            // 
            // biCategories
            // 
            this.biCategories.Caption = "Categories";
            this.biCategories.Id = 1;
            this.biCategories.Name = "biCategories";
            this.biCategories.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.pieseries;
            // 
            // biTransactions
            // 
            this.biTransactions.Caption = "Transactions";
            this.biTransactions.Id = 2;
            this.biTransactions.Name = "biTransactions";
            this.biTransactions.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Transactions;
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.biAccounts,
            this.biCategories,
            this.biTransactions});
            this.tabFormDefaultManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(950, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 585);
            this.barDockControlBottom.Size = new System.Drawing.Size(950, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 585);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(950, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 585);
            // 
            // TabbedFormModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 585);
            this.Controls.Add(this.tabFormControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TabbedFormModule";
            this.ShowIcon = false;
            this.TabFormControl = this.tabFormControl;
            this.Text = "Tabbed Form";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraBars.TabFormControl tabFormControl;
        private XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarButtonItem biAccounts;
        private XtraBars.BarButtonItem biCategories;
        private XtraBars.BarButtonItem biTransactions;
    }
}
