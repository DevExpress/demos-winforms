namespace DevExpress.MVVM.Demos.Views {
    partial class TransactionEditForm {
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
            this.dataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AccountIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.AmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CommentMemoExEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAccountID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategoryID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForComment = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).BeginInit();
            this.dataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayout
            // 
            this.dataLayout.Controls.Add(this.AccountIDLookUpEdit);
            this.dataLayout.Controls.Add(this.CategoryIDLookUpEdit);
            this.dataLayout.Controls.Add(this.DateDateEdit);
            this.dataLayout.Controls.Add(this.AmountSpinEdit);
            this.dataLayout.Controls.Add(this.CommentMemoExEdit);
            this.dataLayout.DataSource = this.bindingSource;
            this.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayout.Location = new System.Drawing.Point(0, 116);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.Root = this.Root;
            this.dataLayout.Size = new System.Drawing.Size(640, 284);
            this.dataLayout.TabIndex = 0;
            this.dataLayout.Text = "dataLayoutControl1";
            // 
            // AccountIDLookUpEdit
            // 
            this.AccountIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "AccountID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AccountIDLookUpEdit.Location = new System.Drawing.Point(60, 12);
            this.AccountIDLookUpEdit.Name = "AccountIDLookUpEdit";
            this.AccountIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AccountIDLookUpEdit.Properties.DataSource = this.accountBindingSource;
            this.AccountIDLookUpEdit.Properties.ValueMember = "ID";
            this.AccountIDLookUpEdit.Size = new System.Drawing.Size(568, 20);
            this.AccountIDLookUpEdit.StyleController = this.dataLayout;
            this.AccountIDLookUpEdit.TabIndex = 4;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Transaction);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Account);
            // 
            // CategoryIDLookUpEdit
            // 
            this.CategoryIDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "CategoryID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CategoryIDLookUpEdit.Location = new System.Drawing.Point(60, 36);
            this.CategoryIDLookUpEdit.Name = "CategoryIDLookUpEdit";
            this.CategoryIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryIDLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.CategoryIDLookUpEdit.Properties.ValueMember = "ID";
            this.CategoryIDLookUpEdit.Size = new System.Drawing.Size(568, 20);
            this.CategoryIDLookUpEdit.StyleController = this.dataLayout;
            this.CategoryIDLookUpEdit.TabIndex = 5;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Category);
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(60, 60);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Size = new System.Drawing.Size(568, 20);
            this.DateDateEdit.StyleController = this.dataLayout;
            this.DateDateEdit.TabIndex = 6;
            // 
            // AmountSpinEdit
            // 
            this.AmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountSpinEdit.Location = new System.Drawing.Point(60, 84);
            this.AmountSpinEdit.Name = "AmountSpinEdit";
            this.AmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AmountSpinEdit.Size = new System.Drawing.Size(568, 20);
            this.AmountSpinEdit.StyleController = this.dataLayout;
            this.AmountSpinEdit.TabIndex = 7;
            // 
            // CommentMemoExEdit
            // 
            this.CommentMemoExEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Comment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CommentMemoExEdit.Location = new System.Drawing.Point(60, 108);
            this.CommentMemoExEdit.Name = "CommentMemoExEdit";
            this.CommentMemoExEdit.Size = new System.Drawing.Size(568, 164);
            this.CommentMemoExEdit.StyleController = this.dataLayout;
            this.CommentMemoExEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(640, 284);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAccountID,
            this.ItemForCategoryID,
            this.ItemForDate,
            this.ItemForAmount,
            this.ItemForComment});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(620, 264);
            // 
            // ItemForAccountID
            // 
            this.ItemForAccountID.Control = this.AccountIDLookUpEdit;
            this.ItemForAccountID.Location = new System.Drawing.Point(0, 0);
            this.ItemForAccountID.Name = "ItemForAccountID";
            this.ItemForAccountID.Size = new System.Drawing.Size(620, 24);
            this.ItemForAccountID.Text = "Account";
            this.ItemForAccountID.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForCategoryID
            // 
            this.ItemForCategoryID.Control = this.CategoryIDLookUpEdit;
            this.ItemForCategoryID.Location = new System.Drawing.Point(0, 24);
            this.ItemForCategoryID.Name = "ItemForCategoryID";
            this.ItemForCategoryID.Size = new System.Drawing.Size(620, 24);
            this.ItemForCategoryID.Text = "Category";
            this.ItemForCategoryID.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(620, 24);
            this.ItemForDate.Text = "Date";
            this.ItemForDate.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpinEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 72);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(620, 24);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForComment
            // 
            this.ItemForComment.Control = this.CommentMemoExEdit;
            this.ItemForComment.Location = new System.Drawing.Point(0, 96);
            this.ItemForComment.Name = "ItemForComment";
            this.ItemForComment.Size = new System.Drawing.Size(620, 168);
            this.ItemForComment.Text = "Comment";
            this.ItemForComment.TextSize = new System.Drawing.Size(45, 13);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Close", this.bbiClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.CategoryViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.CategoryViewModel), "ResetLayout", this.bbiResetLayout)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayout)});
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Enabled = false;
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Save;
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "SaveAndClose";
            this.bbiSaveAndClose.Enabled = false;
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.saveandclose;
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "SaveAndNew";
            this.bbiSaveAndNew.Enabled = false;
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.saveas;
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Enabled = false;
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.ResetView;
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Enabled = false;
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Action_Delete;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.clearheaderandfooter;
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.Id = 1;
            this.bbiCustomize.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Action_Printing_PageSetup;
            this.bbiCustomize.Name = "bbiCustomize";
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save Layout";
            this.bbiSaveLayout.Id = 8;
            this.bbiSaveLayout.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Save;
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiResetLayout
            // 
            this.bbiResetLayout.Caption = "Reset Layout";
            this.bbiResetLayout.Id = 9;
            this.bbiResetLayout.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.ResetView;
            this.bbiResetLayout.Name = "bbiResetLayout";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose, 
            this.bbiCustomize,
            this.bbiSaveLayout,
            this.bbiResetLayout});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(640, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroupLayout});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TRANSACTION";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndNew);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Save";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Edit";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Close";
            // 
            // ribbonPageGroupLayout
            // 
            this.ribbonPageGroupLayout.AllowTextClipping = false;
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Layout";
            // 
            // TransactionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayout);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "TransactionEditForm";
            this.Size = new System.Drawing.Size(640, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).EndInit();
            this.dataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccountID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayout;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.LookUpEdit AccountIDLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit CategoryIDLookUpEdit;
        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private DevExpress.XtraEditors.SpinEdit AmountSpinEdit;
        private DevExpress.XtraEditors.MemoEdit CommentMemoExEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAccountID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForComment;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.BarButtonItem bbiSave;
        private XtraBars.BarButtonItem bbiSaveAndClose;
        private XtraBars.BarButtonItem bbiSaveAndNew;
        private XtraBars.BarButtonItem bbiReset;
        private XtraBars.BarButtonItem bbiDelete;
        private XtraBars.BarButtonItem bbiClose;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLayout;
        private DevExpress.XtraBars.BarButtonItem bbiCustomize;
        private XtraBars.BarButtonItem bbiSaveLayout;
        private XtraBars.BarButtonItem bbiResetLayout;
    }
}
