namespace DevExpress.Xpo.Demos {
    partial class DeletingPersistentObjects {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletingPersistentObjects));
            this.xpProjects = new DevExpress.Xpo.XPCollection();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork();
            this.iProjectStatus = new System.Windows.Forms.ImageList(this.components);
            this.iProjectType = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colProjectType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbDeleteSelected = new DevExpress.XtraEditors.SimpleButton();
            this.sbRestore = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.xpImmediateDeletionProjects = new DevExpress.Xpo.XPCollection();
            this.unitOfWork2 = new DevExpress.Xpo.UnitOfWork();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProjectName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sbAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.sbImmediateDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xpProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpImmediateDeletionProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpProjects
            // 
            this.xpProjects.ObjectType = typeof(DevExpress.Xpo.Demos.Project);
            this.xpProjects.SelectDeleted = true;
            this.xpProjects.Session = this.unitOfWork1;
            // 
            // iProjectStatus
            // 
            this.iProjectStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iProjectStatus.ImageStream")));
            this.iProjectStatus.TransparentColor = System.Drawing.Color.Magenta;
            this.iProjectStatus.Images.SetKeyName(0, "");
            this.iProjectStatus.Images.SetKeyName(1, "");
            this.iProjectStatus.Images.SetKeyName(2, "");
            this.iProjectStatus.Images.SetKeyName(3, "");
            // 
            // iProjectType
            // 
            this.iProjectType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iProjectType.ImageStream")));
            this.iProjectType.TransparentColor = System.Drawing.Color.Magenta;
            this.iProjectType.Images.SetKeyName(0, "");
            this.iProjectType.Images.SetKeyName(1, "");
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(773, 432);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(747, 426);
            this.xtraTabPage1.Text = "Deferred Deletion";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpProjects;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(747, 386);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colProjectName,
            this.colName,
            this.colOwner,
            this.colCreatedDate,
            this.colStatus,
            this.colProjectType});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colOid
            // 
            this.colOid.Caption = "Oid";
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.OptionsColumn.ReadOnly = true;
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            // 
            // colProjectName
            // 
            this.colProjectName.Caption = "Project Name";
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colOwner
            // 
            this.colOwner.Caption = "Owner";
            this.colOwner.FieldName = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 3;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.Caption = "Created Date";
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.iProjectStatus;
            // 
            // colProjectType
            // 
            this.colProjectType.Caption = "Project Type";
            this.colProjectType.ColumnEdit = this.repositoryItemImageComboBox2;
            this.colProjectType.FieldName = "ProjectType";
            this.colProjectType.Name = "colProjectType";
            this.colProjectType.Visible = true;
            this.colProjectType.VisibleIndex = 6;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.iProjectType;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.sbDeleteSelected);
            this.panelControl1.Controls.Add(this.sbRestore);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(747, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // sbDeleteSelected
            // 
            this.sbDeleteSelected.Location = new System.Drawing.Point(8, 8);
            this.sbDeleteSelected.Name = "sbDeleteSelected";
            this.sbDeleteSelected.Size = new System.Drawing.Size(112, 23);
            this.sbDeleteSelected.TabIndex = 3;
            this.sbDeleteSelected.Text = "Delete Record";
            this.sbDeleteSelected.Click += new System.EventHandler(this.sbDeleteSelected_Click);
            // 
            // sbRestore
            // 
            this.sbRestore.Enabled = false;
            this.sbRestore.Location = new System.Drawing.Point(128, 8);
            this.sbRestore.Name = "sbRestore";
            this.sbRestore.Size = new System.Drawing.Size(80, 23);
            this.sbRestore.TabIndex = 2;
            this.sbRestore.Text = "Restore";
            this.sbRestore.Click += new System.EventHandler(this.sbRestore_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Controls.Add(this.panelControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(739, 418);
            this.xtraTabPage2.Text = "Immediate Deletion";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.xpImmediateDeletionProjects;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl2.Location = new System.Drawing.Point(0, 40);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4});
            this.gridControl2.ShowOnlyPredefinedDetails = true;
            this.gridControl2.Size = new System.Drawing.Size(739, 378);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // xpImmediateDeletionProjects
            // 
            this.xpImmediateDeletionProjects.ObjectType = typeof(DevExpress.Xpo.Demos.ImmediateDeletionProject);
            this.xpImmediateDeletionProjects.Session = this.unitOfWork2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProjectName1,
            this.colOwner1,
            this.colCreatedDate1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colProjectName1
            // 
            this.colProjectName1.Caption = "Project Name";
            this.colProjectName1.FieldName = "ProjectName";
            this.colProjectName1.Name = "colProjectName1";
            this.colProjectName1.Visible = true;
            this.colProjectName1.VisibleIndex = 0;
            // 
            // colOwner1
            // 
            this.colOwner1.Caption = "Owner";
            this.colOwner1.FieldName = "Owner";
            this.colOwner1.Name = "colOwner1";
            this.colOwner1.Visible = true;
            this.colOwner1.VisibleIndex = 1;
            // 
            // colCreatedDate1
            // 
            this.colCreatedDate1.Caption = "Created Date";
            this.colCreatedDate1.FieldName = "CreatedDate";
            this.colCreatedDate1.Name = "colCreatedDate1";
            this.colCreatedDate1.Visible = true;
            this.colCreatedDate1.VisibleIndex = 2;
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            this.repositoryItemImageComboBox3.SmallImages = this.iProjectStatus;
            // 
            // repositoryItemImageComboBox4
            // 
            this.repositoryItemImageComboBox4.AutoHeight = false;
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            this.repositoryItemImageComboBox4.SmallImages = this.iProjectType;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.sbAddNew);
            this.panelControl2.Controls.Add(this.sbImmediateDelete);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(739, 40);
            this.panelControl2.TabIndex = 2;
            // 
            // sbAddNew
            // 
            this.sbAddNew.Location = new System.Drawing.Point(120, 8);
            this.sbAddNew.Name = "sbAddNew";
            this.sbAddNew.Size = new System.Drawing.Size(104, 23);
            this.sbAddNew.TabIndex = 1;
            this.sbAddNew.Text = "Add New Record";
            this.sbAddNew.Click += new System.EventHandler(this.sbAddNew_Click);
            // 
            // sbImmediateDelete
            // 
            this.sbImmediateDelete.Location = new System.Drawing.Point(8, 8);
            this.sbImmediateDelete.Name = "sbImmediateDelete";
            this.sbImmediateDelete.Size = new System.Drawing.Size(104, 23);
            this.sbImmediateDelete.TabIndex = 0;
            this.sbImmediateDelete.Text = "Delete";
            this.sbImmediateDelete.Click += new System.EventHandler(this.sbImmediateDelete_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Oid";
            this.gridColumn1.FieldName = "Oid";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Project Name";
            this.gridColumn2.FieldName = "ProjectName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Owner";
            this.gridColumn3.FieldName = "Owner";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Created Date";
            this.gridColumn4.FieldName = "CreatedDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Produc tName";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "Order Date";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
            // 
            // DeletingPersistentObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "DeletingPersistentObjects";
            this.Size = new System.Drawing.Size(773, 432);
            //this.TutorialInfo.AboutFile = null;
            //this.TutorialInfo.Description = null;
            //this.TutorialInfo.TutorialName = null;
            //this.TutorialInfo.WhatsThisCodeFile = null;
            //this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.DeletingPersistentObjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpImmediateDeletionProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.XPCollection xpProjects;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private System.Windows.Forms.ImageList iProjectStatus;
        private System.Windows.Forms.ImageList iProjectType;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.Xpo.XPCollection xpImmediateDeletionProjects;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbDeleteSelected;
        private DevExpress.XtraEditors.SimpleButton sbRestore;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton sbImmediateDelete;
        private DevExpress.Xpo.UnitOfWork unitOfWork2;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName1;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate1;
        private DevExpress.XtraEditors.SimpleButton sbAddNew;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private System.ComponentModel.IContainer components;

    }
}
