namespace DevExpress.XtraGrid.Demos {
    partial class FindFilter {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindFilter));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucFindOptions1 = new DevExpress.XtraGrid.Demos.ucFindOptions();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colPhone,
            this.colFax});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollStep = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            this.gridView1.OptionsFind.ParserKind = DevExpress.Data.Filtering.FindPanelParserKind.And;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewFieldName = "Address";
            this.gridView1.FilterEditorCreated += new DevExpress.XtraGrid.Views.Base.FilterControlEventHandler(this.gridView1_FilterEditorCreated);
            // 
            // colCustomerID
            // 
            resources.ApplyResources(this.colCustomerID, "colCustomerID");
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.OptionsFilter.AllowFilter = false;
            // 
            // colCompanyName
            // 
            resources.ApplyResources(this.colCompanyName, "colCompanyName");
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colCompanyName.Summary"))))});
            // 
            // colContactName
            // 
            resources.ApplyResources(this.colContactName, "colContactName");
            this.colContactName.FieldName = "ContactName";
            this.colContactName.ImageOptions.ImageIndex = ((int)(resources.GetObject("colContactName.ImageOptions.ImageIndex")));
            this.colContactName.Name = "colContactName";
            // 
            // colContactTitle
            // 
            resources.ApplyResources(this.colContactTitle, "colContactTitle");
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            // 
            // colAddress
            // 
            resources.ApplyResources(this.colAddress, "colAddress");
            this.colAddress.FieldName = "Address";
            this.colAddress.ImageOptions.ImageIndex = ((int)(resources.GetObject("colAddress.ImageOptions.ImageIndex")));
            this.colAddress.Name = "colAddress";
            // 
            // colCity
            // 
            resources.ApplyResources(this.colCity, "colCity");
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            // 
            // colRegion
            // 
            resources.ApplyResources(this.colRegion, "colRegion");
            this.colRegion.ColumnEdit = this.repositoryItemComboBox1;
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            // 
            // repositoryItemComboBox1
            // 
            resources.ApplyResources(this.repositoryItemComboBox1, "repositoryItemComboBox1");
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox1.Buttons"))))});
            this.repositoryItemComboBox1.DropDownRows = 12;
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            resources.GetString("repositoryItemComboBox1.Items"),
            resources.GetString("repositoryItemComboBox1.Items1"),
            resources.GetString("repositoryItemComboBox1.Items2"),
            resources.GetString("repositoryItemComboBox1.Items3"),
            resources.GetString("repositoryItemComboBox1.Items4"),
            resources.GetString("repositoryItemComboBox1.Items5"),
            resources.GetString("repositoryItemComboBox1.Items6"),
            resources.GetString("repositoryItemComboBox1.Items7"),
            resources.GetString("repositoryItemComboBox1.Items8"),
            resources.GetString("repositoryItemComboBox1.Items9"),
            resources.GetString("repositoryItemComboBox1.Items10"),
            resources.GetString("repositoryItemComboBox1.Items11"),
            resources.GetString("repositoryItemComboBox1.Items12"),
            resources.GetString("repositoryItemComboBox1.Items13"),
            resources.GetString("repositoryItemComboBox1.Items14"),
            resources.GetString("repositoryItemComboBox1.Items15"),
            resources.GetString("repositoryItemComboBox1.Items16"),
            resources.GetString("repositoryItemComboBox1.Items17")});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colPostalCode
            // 
            resources.ApplyResources(this.colPostalCode, "colPostalCode");
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            // 
            // colCountry
            // 
            resources.ApplyResources(this.colCountry, "colCountry");
            this.colCountry.ColumnEdit = this.repositoryItemComboBox2;
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // repositoryItemComboBox2
            // 
            resources.ApplyResources(this.repositoryItemComboBox2, "repositoryItemComboBox2");
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox2.Buttons"))))});
            this.repositoryItemComboBox2.DropDownRows = 12;
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            resources.GetString("repositoryItemComboBox2.Items"),
            resources.GetString("repositoryItemComboBox2.Items1"),
            resources.GetString("repositoryItemComboBox2.Items2"),
            resources.GetString("repositoryItemComboBox2.Items3"),
            resources.GetString("repositoryItemComboBox2.Items4"),
            resources.GetString("repositoryItemComboBox2.Items5"),
            resources.GetString("repositoryItemComboBox2.Items6"),
            resources.GetString("repositoryItemComboBox2.Items7"),
            resources.GetString("repositoryItemComboBox2.Items8"),
            resources.GetString("repositoryItemComboBox2.Items9"),
            resources.GetString("repositoryItemComboBox2.Items10"),
            resources.GetString("repositoryItemComboBox2.Items11"),
            resources.GetString("repositoryItemComboBox2.Items12"),
            resources.GetString("repositoryItemComboBox2.Items13"),
            resources.GetString("repositoryItemComboBox2.Items14"),
            resources.GetString("repositoryItemComboBox2.Items15"),
            resources.GetString("repositoryItemComboBox2.Items16"),
            resources.GetString("repositoryItemComboBox2.Items17"),
            resources.GetString("repositoryItemComboBox2.Items18"),
            resources.GetString("repositoryItemComboBox2.Items19"),
            resources.GetString("repositoryItemComboBox2.Items20")});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // colPhone
            // 
            resources.ApplyResources(this.colPhone, "colPhone");
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            // 
            // colFax
            // 
            resources.ApplyResources(this.colFax, "colFax");
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            // 
            // ucFindOptions1
            // 
            resources.ApplyResources(this.ucFindOptions1, "ucFindOptions1");
            this.ucFindOptions1.Name = "ucFindOptions1";
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            resources.ApplyResources(this.navigationPane1, "navigationPane1");
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(249, 624);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            // 
            // navigationPage1
            // 
            resources.ApplyResources(this.navigationPage1, "navigationPage1");
            this.navigationPage1.Controls.Add(this.layoutControl2);
            this.navigationPage1.Name = "navigationPage1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.AllowCustomization = false;
            this.layoutControl2.Controls.Add(this.ucFindOptions1);
            resources.ApplyResources(this.layoutControl2, "layoutControl2");
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 450, 350);
            this.layoutControl2.Root = this.layoutControlGroup2;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 591);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ucFindOptions1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(249, 591);
            this.layoutControlItem3.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.navigationPane1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // FindFilter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "FindFilter";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private GridControl gridControl1;
        private ucFindOptions ucFindOptions1;
        private XtraBars.Navigation.TabPane navigationPane1;
        private XtraBars.Navigation.TabNavigationPage navigationPage1;
        private XtraLayout.LayoutControl layoutControl2;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraEditors.PanelControl panelControl1;
        private XtraEditors.SidePanel sidePanel1;
    }
}
