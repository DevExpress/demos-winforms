namespace DevExpress.XtraTreeList.Demos {
    partial class NodesFiltering {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodesFiltering));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.navigationPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.filterPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ucFilterOptions1 = new DevExpress.XtraTreeList.Demos.Options.ucFilterOptions();
            this.findPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ucFindOptions1 = new DevExpress.XtraTreeList.Demos.Options.ucFindOptions();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).BeginInit();
            this.navigationPane.SuspendLayout();
            this.filterPage.SuspendLayout();
            this.findPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsFilter.ExpandNodesOnFiltering = true;
            this.treeList1.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.treeList1.Size = new System.Drawing.Size(561, 532);
            this.treeList1.StateImageList = this.svgImageCollection1;
            this.treeList1.TabIndex = 12;
            this.treeList1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Job Title";
            this.treeListColumn1.FieldName = "JobTitle";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 105;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "First Name";
            this.treeListColumn2.FieldName = "FirstName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 106;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Last Name";
            this.treeListColumn3.FieldName = "LastName";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 106;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Birth Date";
            this.treeListColumn4.ColumnEdit = this.repositoryItemDateEdit1;
            this.treeListColumn4.FieldName = "BirthDate";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 105;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Origin State";
            this.treeListColumn5.FieldName = "StateProvinceName";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 5;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Origin City";
            this.treeListColumn6.FieldName = "City";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 4;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Phone";
            this.treeListColumn7.FieldName = "Phone";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 6;
            this.treeListColumn7.Width = 105;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("User", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.User"))));
            this.svgImageCollection1.Add("Marketing", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Marketing"))));
            this.svgImageCollection1.Add("Employeer", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Employeer"))));
            this.svgImageCollection1.Add("User1", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.User1"))));
            this.svgImageCollection1.Add("Engineering", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Engineering"))));
            this.svgImageCollection1.Add("Sales", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Sales"))));
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.navigationPane);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(561, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(237, 532);
            this.sidePanel1.TabIndex = 11;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // navigationPane
            // 
            this.navigationPane.Controls.Add(this.filterPage);
            this.navigationPane.Controls.Add(this.findPage);
            this.navigationPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane.Location = new System.Drawing.Point(1, 0);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.navigationPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.findPage,
            this.filterPage});
            this.navigationPane.RegularSize = new System.Drawing.Size(236, 532);
            this.navigationPane.SelectedPage = this.findPage;
            this.navigationPane.Size = new System.Drawing.Size(236, 532);
            this.navigationPane.TabIndex = 11;
            this.navigationPane.Text = "navigationPane";
            // 
            // filterPage
            // 
            this.filterPage.Caption = "Filter Options";
            this.filterPage.Controls.Add(this.ucFilterOptions1);
            this.filterPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("filterPage.ImageOptions.Image")));
            this.filterPage.ImageOptions.ImageUri.Uri = "New";
            this.filterPage.Name = "filterPage";
            this.filterPage.Size = new System.Drawing.Size(236, 456);
            // 
            // ucFilterOptions1
            // 
            this.ucFilterOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFilterOptions1.Location = new System.Drawing.Point(0, 0);
            this.ucFilterOptions1.Name = "ucFilterOptions1";
            this.ucFilterOptions1.Size = new System.Drawing.Size(236, 456);
            this.ucFilterOptions1.TabIndex = 0;
            // 
            // findPage
            // 
            this.findPage.Caption = "Find Options";
            this.findPage.Controls.Add(this.ucFindOptions1);
            this.findPage.Name = "findPage";
            this.findPage.Size = new System.Drawing.Size(236, 499);
            // 
            // ucFindOptions1
            // 
            this.ucFindOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFindOptions1.Location = new System.Drawing.Point(0, 0);
            this.ucFindOptions1.Name = "ucFindOptions1";
            this.ucFindOptions1.Size = new System.Drawing.Size(236, 499);
            this.ucFindOptions1.TabIndex = 0;
            // 
            // NodesFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "NodesFiltering";
            this.Size = new System.Drawing.Size(798, 532);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).EndInit();
            this.navigationPane.ResumeLayout(false);
            this.filterPage.ResumeLayout(false);
            this.findPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private TreeList treeList1;
        private Columns.TreeListColumn treeListColumn1;
        private Columns.TreeListColumn treeListColumn2;
        private Columns.TreeListColumn treeListColumn3;
        private Columns.TreeListColumn treeListColumn4;
        private XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private Columns.TreeListColumn treeListColumn5;
        private Columns.TreeListColumn treeListColumn6;
        private Columns.TreeListColumn treeListColumn7;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane navigationPane;
        private XtraBars.Navigation.TabNavigationPage filterPage;
        private XtraBars.Navigation.TabNavigationPage findPage;
        private Options.ucFilterOptions ucFilterOptions1;
        private Options.ucFindOptions ucFindOptions1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
