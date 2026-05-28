namespace DevExpress.MVVM.Demos.Views {
    partial class DataLayoutViewModule {
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.sourceCode = new DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl();
            this.AccountLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CommentMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForComment = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.sourceCode);
            this.dataLayoutControl1.Controls.Add(this.AccountLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.CategoryLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CommentMemoEdit);
            this.dataLayoutControl1.DataSource = this.transactionBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(5, 116);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(779, 311);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // sourceCode
            // 
            this.sourceCode.CurrentNestedType = null;
            this.sourceCode.Location = new System.Drawing.Point(12, 203);
            this.sourceCode.Margin = new System.Windows.Forms.Padding(0);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.RichText = "";
            this.sourceCode.Size = new System.Drawing.Size(755, 96);
            this.sourceCode.TabIndex = 6;
            // 
            // AccountLookUpEdit
            // 
            this.AccountLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionBindingSource, "AccountID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AccountLookUpEdit.Location = new System.Drawing.Point(69, 12);
            this.AccountLookUpEdit.Name = "AccountLookUpEdit";
            this.AccountLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AccountLookUpEdit.Properties.DataSource = this.accountBindingSource;
            this.AccountLookUpEdit.Properties.NullText = "";
            this.AccountLookUpEdit.Properties.ValueMember = "ID";
            this.AccountLookUpEdit.Size = new System.Drawing.Size(698, 20);
            this.AccountLookUpEdit.StyleController = this.dataLayoutControl1;
            this.AccountLookUpEdit.TabIndex = 4;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Transaction);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Account);
            // 
            // CategoryLookUpEdit
            // 
            this.CategoryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionBindingSource, "CategoryID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CategoryLookUpEdit.Location = new System.Drawing.Point(69, 36);
            this.CategoryLookUpEdit.Name = "CategoryLookUpEdit";
            this.CategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.CategoryLookUpEdit.Properties.NullText = "";
            this.CategoryLookUpEdit.Properties.ValueMember = "ID";
            this.CategoryLookUpEdit.Size = new System.Drawing.Size(698, 20);
            this.CategoryLookUpEdit.StyleController = this.dataLayoutControl1;
            this.CategoryLookUpEdit.TabIndex = 5;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DevExpress.MVVM.Demos.Model.Category);
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionBindingSource, "Date", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(69, 60);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.NullValuePrompt = null;
            this.DateDateEdit.Size = new System.Drawing.Size(698, 20);
            this.DateDateEdit.StyleController = this.dataLayoutControl1;
            this.DateDateEdit.TabIndex = 6;
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionBindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AmountTextEdit.Location = new System.Drawing.Point(69, 84);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Mask.EditMask = "c";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Properties.NullValuePrompt = null;
            this.AmountTextEdit.Size = new System.Drawing.Size(698, 20);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 7;
            // 
            // CommentMemoEdit
            // 
            this.CommentMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transactionBindingSource, "Comment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CommentMemoEdit.Location = new System.Drawing.Point(69, 108);
            this.CommentMemoEdit.Name = "CommentMemoEdit";
            this.CommentMemoEdit.Properties.NullValuePrompt = null;
            this.CommentMemoEdit.Size = new System.Drawing.Size(698, 86);
            this.CommentMemoEdit.StyleController = this.dataLayoutControl1;
            this.CommentMemoEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(779, 311);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAccount,
            this.ItemForCategory,
            this.ItemForDate,
            this.ItemForAmount,
            this.ItemForComment,
            this.layoutControlItem1,
            this.splitterItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(759, 291);
            // 
            // ItemForAccount
            // 
            this.ItemForAccount.Control = this.AccountLookUpEdit;
            this.ItemForAccount.Location = new System.Drawing.Point(0, 0);
            this.ItemForAccount.Name = "ItemForAccount";
            this.ItemForAccount.Size = new System.Drawing.Size(759, 24);
            this.ItemForAccount.Text = "ACCOUNT";
            this.ItemForAccount.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForCategory
            // 
            this.ItemForCategory.Control = this.CategoryLookUpEdit;
            this.ItemForCategory.Location = new System.Drawing.Point(0, 24);
            this.ItemForCategory.Name = "ItemForCategory";
            this.ItemForCategory.Size = new System.Drawing.Size(759, 24);
            this.ItemForCategory.Text = "CATEGORY";
            this.ItemForCategory.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.Location = new System.Drawing.Point(0, 48);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(759, 24);
            this.ItemForDate.Text = "DATE";
            this.ItemForDate.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 72);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(759, 24);
            this.ItemForAmount.Text = "AMOUNT";
            this.ItemForAmount.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForComment
            // 
            this.ItemForComment.Control = this.CommentMemoEdit;
            this.ItemForComment.Location = new System.Drawing.Point(0, 96);
            this.ItemForComment.Name = "ItemForComment";
            this.ItemForComment.Size = new System.Drawing.Size(759, 90);
            this.ItemForComment.StartNewLine = true;
            this.ItemForComment.Text = "COMMENT";
            this.ItemForComment.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sourceCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(759, 100);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 186);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(759, 5);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Reset", this.bbiReset)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 8;
            this.bbiSave.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Save;
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 11;
            this.bbiReset.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.ResetView;
            this.bbiReset.Name = "bbiReset";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSave,
            this.bbiReset});
            this.ribbonControl1.Location = new System.Drawing.Point(5, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(779, 116);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TRANSACTION";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // DataLayoutViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DataLayoutViewModule";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommentMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private XtraEditors.LookUpEdit AccountLookUpEdit;
        private XtraEditors.LookUpEdit CategoryLookUpEdit;
        private XtraEditors.DateEdit DateDateEdit;
        private XtraEditors.TextEdit AmountTextEdit;
        private XtraEditors.MemoEdit CommentMemoEdit;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem ItemForAccount;
        private XtraLayout.LayoutControlItem ItemForCategory;
        private XtraLayout.LayoutControlItem ItemForDate;
        private XtraLayout.LayoutControlItem ItemForAmount;
        private XtraLayout.LayoutControlItem ItemForComment;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraBars.BarButtonItem bbiSave;
        private XtraBars.BarButtonItem bbiReset;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DXperience.Demos.CodeDemo.RichEditUserControl sourceCode;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.SplitterItem splitterItem1;
    }
}
