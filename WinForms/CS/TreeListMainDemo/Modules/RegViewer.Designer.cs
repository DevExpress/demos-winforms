namespace DevExpress.XtraTreeList.Demos {
    partial class TreeListRegViewer {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.sidePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList1.ChildListFieldName = "Items";
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.EnableDynamicLoading = false;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsBehavior.ResizeNodes = false;
            this.treeList1.OptionsMenu.EnableFooterMenu = false;
            this.treeList1.OptionsPrint.PrintHorzLines = false;
            this.treeList1.OptionsPrint.PrintVertLines = false;
            this.treeList1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeList1.OptionsView.RowImagesShowMode = DevExpress.XtraTreeList.RowImagesShowMode.InCell;
            this.treeList1.SelectImageList = this.svgImageCollection1;
            this.treeList1.Size = new System.Drawing.Size(322, 290);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeViewFieldName = "Name";
            this.treeList1.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.treeList1_GetSelectImage);
            this.treeList1.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.treeList1_BeforeExpand);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("electronics_desktopmac", "image://svgimages/icon builder/electronics_desktopmac.svg");
            this.svgImageCollection1.Add("actions_folderclose", "image://svgimages/icon builder/actions_folderclose.svg");
            this.svgImageCollection1.Add("open", "image://svgimages/actions/open.svg");
            this.svgImageCollection1.Add("string", "image://svgimages/snap/string.svg");
            this.svgImageCollection1.Add("array", "image://svgimages/snap/array.svg");
            // 
            // treeList2
            // 
            this.treeList2.AutoFillColumn = this.treeListColumn2;
            this.treeList2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList2.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList2.Location = new System.Drawing.Point(0, 0);
            this.treeList2.Name = "treeList2";
            this.treeList2.OptionsBehavior.Editable = false;
            this.treeList2.OptionsBehavior.ResizeNodes = false;
            this.treeList2.OptionsMenu.EnableFooterMenu = false;
            this.treeList2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList2.OptionsView.AutoCalcPreviewLineCount = true;
            this.treeList2.OptionsView.AutoWidth = false;
            this.treeList2.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeList2.OptionsView.ShowHorzLines = false;
            this.treeList2.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList2.OptionsView.ShowIndicator = false;
            this.treeList2.OptionsView.ShowRoot = false;
            this.treeList2.OptionsView.ShowVertLines = false;
            this.treeList2.SelectImageList = this.svgImageCollection1;
            this.treeList2.Size = new System.Drawing.Size(347, 290);
            this.treeList2.TabIndex = 1;
            this.treeList2.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.treeList2_GetSelectImage);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Data";
            this.treeListColumn2.FieldName = "Data";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            this.treeListColumn2.Width = 39;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 187;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Type";
            this.treeListColumn3.FieldName = "Type";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            this.treeListColumn3.Width = 121;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.treeList1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 19);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(323, 290);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.treeList2);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(323, 19);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(347, 290);
            this.sidePanel2.TabIndex = 4;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Properties.UseReadOnlyAppearance = false;
            this.textEdit1.Size = new System.Drawing.Size(670, 18);
            this.textEdit1.TabIndex = 1;
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.Controls.Add(this.textEdit1);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel3.Location = new System.Drawing.Point(0, 0);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(670, 19);
            this.sidePanel3.TabIndex = 5;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // TreeListRegViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.sidePanel3);
            this.Name = "TreeListRegViewer";
            this.Size = new System.Drawing.Size(670, 309);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.sidePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private System.ComponentModel.IContainer components = null;
        private XtraEditors.SidePanel sidePanel1;
        private XtraEditors.SidePanel sidePanel2;
        private XtraEditors.TextEdit textEdit1;
        private XtraEditors.SidePanel sidePanel3;
        private Utils.SvgImageCollection svgImageCollection1;
        private Columns.TreeListColumn treeListColumn1;
        private Columns.TreeListColumn treeListColumn2;
        private Columns.TreeListColumn treeListColumn3;
    }
}
