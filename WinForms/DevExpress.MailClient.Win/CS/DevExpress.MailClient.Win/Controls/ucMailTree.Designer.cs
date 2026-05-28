namespace DevExpress.MailClient.Win {
    partial class ucMailTree {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMailTree));
            this.treeList1 = new DevExpress.MailClient.Win.MyTreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImageIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.icFolders = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icFolders)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.AllowDrop = true;
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colType,
            this.colFolder,
            this.colImageIndex,
            this.colData});
            this.treeList1.DataSource = null;
            resources.ApplyResources(this.treeList1, "treeList1");
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.OptionsMenu.EnableNodeMenu = false;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit1});
            this.treeList1.SelectImageList = this.icFolders;
            this.treeList1.CustomNodeCellEditForEditing += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(this.treeList1_CustomNodeCellEditForEditing);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.HiddenEditor += new System.EventHandler(this.treeList1_HiddenEditor);
            this.treeList1.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeList1_CustomDrawNodeCell);
            this.treeList1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeList1_DragDrop);
            this.treeList1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeList1_DragEnter);
            this.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            // 
            // colName
            // 
            resources.ApplyResources(this.colName, "colName");
            this.colName.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            resources.ApplyResources(this.repositoryItemButtonEdit1, "repositoryItemButtonEdit1");
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colType
            // 
            this.colType.Name = "colType";
            // 
            // colFolder
            // 
            this.colFolder.Name = "colFolder";
            // 
            // colImageIndex
            // 
            this.colImageIndex.FieldName = "ImageIndex";
            this.colImageIndex.Name = "colImageIndex";
            // 
            // colData
            // 
            this.colData.FieldName = "colData";
            this.colData.Name = "colData";
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // icFolders
            // 
            this.icFolders.Add("InBox", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.InBox"))));
            this.icFolders.Add("SendItem", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.SendItem"))));
            this.icFolders.Add("DeletedItem", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.DeletedItem"))));
            this.icFolders.Add("Draft", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.Draft"))));
            this.icFolders.Add("Customer", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.Customer"))));
            this.icFolders.Add("Announcements", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.Announcements"))));
            this.icFolders.Add("Management", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.Management"))));
            this.icFolders.Add("Feed", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.Feed"))));
            this.icFolders.Add("Sale", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.Sale"))));
            this.icFolders.Add("Settings", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icFolders.Settings"))));
            // 
            // ucMailTree
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "ucMailTree";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icFolders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyTreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImageIndex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private Utils.SvgImageCollection icFolders;
    }
}
