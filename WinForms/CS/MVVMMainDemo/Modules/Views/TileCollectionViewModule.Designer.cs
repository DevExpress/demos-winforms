namespace DevExpress.MVVM.Demos.Views {
    partial class TileCollectionViewModule {
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
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sourceCode = new DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sourceCodeItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.viewItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCodeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "New", this.bbiNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Edit", "SelectedEntity", this.bbiEdit),
            DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Delete", "SelectedEntity", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Refresh", this.bbiRefresh)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel);
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 1;
            this.bbiNew.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources._new;
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Enabled = false;
            this.bbiEdit.Id = 2;
            this.bbiEdit.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Action_Edit;
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Enabled = false;
            this.bbiDelete.Id = 3;
            this.bbiDelete.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Action_Delete;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageOptions.SvgImage = global::DevExpress.MVVM.Demos.Properties.Resources.Refresh;
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(5, 0);
            this.ribbonControl1.MaxItemId = 8;
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
            this.ribbonPage1.Text = "ACCOUNTS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowSelectedItem = true;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(2, 2);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(775, 172);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.tileControl1);
            this.layoutControl1.Controls.Add(this.sourceCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(5, 116);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(779, 311);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sourceCode
            // 
            this.sourceCode.CurrentNestedType = null;
            this.sourceCode.Location = new System.Drawing.Point(0, 181);
            this.sourceCode.Padding = new System.Windows.Forms.Padding(0);
            this.sourceCode.Margin = new System.Windows.Forms.Padding(0);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.RichText = "";
            this.sourceCode.Size = new System.Drawing.Size(779, 130);
            this.sourceCode.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sourceCodeItem,
            this.viewItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(779, 311);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // sourceCodeItem
            // 
            this.sourceCodeItem.Control = this.sourceCode;
            this.sourceCodeItem.Location = new System.Drawing.Point(0, 184);
            this.sourceCodeItem.Name = "sourceCodeItem";
            this.sourceCodeItem.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 8, 16);
            this.sourceCodeItem.Size = new System.Drawing.Size(779, 130);
            this.sourceCodeItem.TextSize = new System.Drawing.Size(0, 0);
            this.sourceCodeItem.TextVisible = false;
            // 
            // viewItem
            // 
            this.viewItem.Control = this.tileControl1;
            this.viewItem.Location = new System.Drawing.Point(0, 0);
            this.viewItem.Name = "viewItem";
            this.viewItem.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 16, 16, 8);
            this.viewItem.Size = new System.Drawing.Size(779, 179);
            this.viewItem.TextSize = new System.Drawing.Size(0, 0);
            this.viewItem.TextVisible = false;
            // 
            // TileCollectionViewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "TileCollectionViewModule";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCodeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.BarButtonItem bbiNew;
        private XtraBars.BarButtonItem bbiEdit;
        private XtraBars.BarButtonItem bbiDelete;
        private XtraBars.BarButtonItem bbiRefresh;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraEditors.TileControl tileControl1;
        private XtraEditors.TileGroup tileGroup2;
        private XtraLayout.LayoutControl layoutControl1;
        private DXperience.Demos.CodeDemo.RichEditUserControl sourceCode;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem sourceCodeItem;
        private XtraLayout.LayoutControlItem viewItem;
    }
}
