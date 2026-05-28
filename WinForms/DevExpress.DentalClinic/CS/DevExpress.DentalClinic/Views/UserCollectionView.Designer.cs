namespace DevExpress.DentalClinic.View {
    partial class UserCollectionView {
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
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastVisit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNextVisit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gcPatients = new DevExpress.XtraGrid.GridControl();
            this.gvPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.sbEdit = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.UserCollectionViewModel);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(DevExpress.DentalClinic.Model.Employee);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Phone";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // colLastVisit
            // 
            this.colLastVisit.FieldName = "LastVisit";
            this.colLastVisit.Name = "colLastVisit";
            this.colLastVisit.OptionsColumn.AllowEdit = false;
            this.colLastVisit.Visible = true;
            this.colLastVisit.VisibleIndex = 2;
            // 
            // colNextVisit
            // 
            this.colNextVisit.FieldName = "NextVisit";
            this.colNextVisit.Name = "colNextVisit";
            this.colNextVisit.OptionsColumn.AllowEdit = false;
            this.colNextVisit.Visible = true;
            this.colNextVisit.VisibleIndex = 3;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchControl1);
            this.layoutControl1.Controls.Add(this.gcPatients);
            this.layoutControl1.Controls.Add(this.sbEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1333, 835);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcPatients;
            this.searchControl1.Location = new System.Drawing.Point(8, 1);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchControl1.MaximumSize = new System.Drawing.Size(0, 30);
            this.searchControl1.MinimumSize = new System.Drawing.Size(0, 30);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcPatients;
            this.searchControl1.Size = new System.Drawing.Size(1286, 30);
            this.searchControl1.StyleController = this.layoutControl1;
            this.searchControl1.TabIndex = 4;
            // 
            // gcPatients
            // 
            this.gcPatients.DataSource = this.employeeBindingSource;
            this.gcPatients.Location = new System.Drawing.Point(2, 39);
            this.gcPatients.MainView = this.gvPatients;
            this.gcPatients.Name = "gcPatients";
            this.gcPatients.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gcPatients.Size = new System.Drawing.Size(1329, 794);
            this.gcPatients.TabIndex = 2;
            this.gcPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatients});
            // 
            // gvPatients
            // 
            this.gvPatients.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPatients.ColumnPanelRowHeight = 30;
            this.gvPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsActive,
            this.colUserName,
            this.colFirstName,
            this.colLastName,
            this.colPhone,
            this.colEmail});
            this.gvPatients.DetailHeight = 227;
            this.gvPatients.FixedLineWidth = 1;
            this.gvPatients.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvPatients.GridControl = this.gcPatients;
            this.gvPatients.Name = "gvPatients";
            this.gvPatients.OptionsBehavior.Editable = false;
            this.gvPatients.OptionsDetail.EnableMasterViewMode = false;
            this.gvPatients.OptionsDetail.ShowDetailTabs = false;
            this.gvPatients.OptionsDetail.SmartDetailExpand = false;
            this.gvPatients.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPatients.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvPatients.OptionsView.ShowGroupPanel = false;
            this.gvPatients.OptionsView.ShowIndicator = false;
            this.gvPatients.RowHeight = 30;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemImageComboBox1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemImageComboBox1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // sbEdit
            // 
            this.sbEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbEdit.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.Edit;
            this.sbEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbEdit.Location = new System.Drawing.Point(1300, 1);
            this.sbEdit.MaximumSize = new System.Drawing.Size(30, 30);
            this.sbEdit.MinimumSize = new System.Drawing.Size(30, 30);
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(30, 30);
            this.sbEdit.StyleController = this.layoutControl1;
            this.sbEdit.TabIndex = 6;
            this.sbEdit.Text = "simpleButton2";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1333, 835);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcPatients;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 37);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1333, 798);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 3, 1, 6);
            this.layoutControlItem3.Size = new System.Drawing.Size(1297, 37);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(1297, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(36, 34);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(36, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 1, 1);
            this.layoutControlItem5.Size = new System.Drawing.Size(36, 37);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // UserCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserCollectionView";
            this.Size = new System.Drawing.Size(1333, 835);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private XtraGrid.Columns.GridColumn colName;
        private XtraGrid.Columns.GridColumn gridColumn1;
        private XtraGrid.Columns.GridColumn colLastVisit;
        private XtraGrid.Columns.GridColumn colNextVisit;
        private XtraGrid.Columns.GridColumn colStatus;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.SearchControl searchControl1;
        private XtraGrid.GridControl gcPatients;
        private XtraGrid.Views.Grid.GridView gvPatients;
        private XtraGrid.Columns.GridColumn colIsActive;
        private XtraGrid.Columns.GridColumn colUserName;
        private XtraGrid.Columns.GridColumn colFirstName;
        private XtraGrid.Columns.GridColumn colLastName;
        private XtraGrid.Columns.GridColumn colPhone;
        private XtraGrid.Columns.GridColumn colEmail;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private XtraEditors.SimpleButton sbEdit;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
