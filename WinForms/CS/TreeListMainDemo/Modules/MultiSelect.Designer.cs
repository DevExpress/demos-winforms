namespace DevExpress.XtraTreeList.Demos {
    partial class MultiSelect {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiSelect));
            this.treeList = new DevExpress.XtraTreeList.TreeList();
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.optionsPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ucMultiSelectOptions1 = new DevExpress.XtraTreeList.Demos.Options.ucMultiSelectOptions();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.optionsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7});
            this.treeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.treeList.OptionsSelection.MultiSelect = true;
            this.treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect;
            this.treeList.OptionsSelection.UseIndicatorForSelection = true;
            this.treeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.treeList.Size = new System.Drawing.Size(548, 456);
            this.treeList.StateImageList = this.svgImageCollection1;
            this.treeList.TabIndex = 10;
            this.treeList.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Job Title";
            this.treeListColumn1.FieldName = "JobTitle";
            this.treeListColumn1.MinWidth = 33;
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
            this.sidePanel1.Controls.Add(this.navigationPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(548, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(250, 456);
            this.sidePanel1.TabIndex = 11;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.optionsPage);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(1, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.optionsPage});
            this.navigationPane1.RegularSize = new System.Drawing.Size(249, 456);
            this.navigationPane1.SelectedPage = this.optionsPage;
            this.navigationPane1.Size = new System.Drawing.Size(249, 456);
            this.navigationPane1.TabIndex = 13;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // optionsPage
            // 
            this.optionsPage.Caption = "Options";
            this.optionsPage.Controls.Add(this.ucMultiSelectOptions1);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Size = new System.Drawing.Size(249, 423);
            // 
            // ucMultiSelectOptions1
            // 
            this.ucMultiSelectOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMultiSelectOptions1.Location = new System.Drawing.Point(0, 0);
            this.ucMultiSelectOptions1.Name = "ucMultiSelectOptions1";
            this.ucMultiSelectOptions1.Size = new System.Drawing.Size(249, 423);
            this.ucMultiSelectOptions1.TabIndex = 0;
            // 
            // MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList);
            this.Controls.Add(this.sidePanel1);
            this.Name = "MultiSelect";
            this.Size = new System.Drawing.Size(798, 456);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.optionsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane navigationPane1;
        private XtraBars.Navigation.TabNavigationPage optionsPage;
        private Options.ucMultiSelectOptions ucMultiSelectOptions1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
