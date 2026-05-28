using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    partial class MasterDetailGrouping {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetailGrouping));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShippedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipVia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chJoined = new DevExpress.XtraEditors.CheckButton();
            this.chOwner = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colCustomer,
            this.colOrderDate,
            this.colRequiredDate,
            this.colShippedDate,
            this.colShipVia,
            this.colFreight,
            this.colShipName,
            this.colShipAddress,
            this.colShipCity,
            this.colShipRegion,
            this.colShipPostalCode,
            this.colShipCountry});
            this.gridView2.DetailHeight = 300;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView2.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colShipVia, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2.EndGrouping += new System.EventHandler(this.gridView_EndGrouping);
            // 
            // colOrderID
            // 
            resources.ApplyResources(this.colOrderID, "colOrderID");
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.OptionsFilter.AllowFilter = false;
            // 
            // colCustomer
            // 
            resources.ApplyResources(this.colCustomer, "colCustomer");
            this.colCustomer.FieldName = "CustomerID";
            this.colCustomer.Name = "colCustomer";
            // 
            // colOrderDate
            // 
            resources.ApplyResources(this.colOrderDate, "colOrderDate");
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            // 
            // colRequiredDate
            // 
            resources.ApplyResources(this.colRequiredDate, "colRequiredDate");
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.Name = "colRequiredDate";
            // 
            // colShippedDate
            // 
            resources.ApplyResources(this.colShippedDate, "colShippedDate");
            this.colShippedDate.FieldName = "ShippedDate";
            this.colShippedDate.Name = "colShippedDate";
            // 
            // colShipVia
            // 
            resources.ApplyResources(this.colShipVia, "colShipVia");
            this.colShipVia.ColumnEdit = this.repositoryItemImageComboBox3;
            this.colShipVia.FieldName = "ShipVia";
            this.colShipVia.ImageOptions.ImageIndex = ((int)(resources.GetObject("colShipVia.ImageOptions.ImageIndex")));
            this.colShipVia.Name = "colShipVia";
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AllowFocused = false;
            resources.ApplyResources(this.repositoryItemImageComboBox3, "repositoryItemImageComboBox3");
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox3.Buttons"))))});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items6"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items7"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items8"))))});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // colFreight
            // 
            resources.ApplyResources(this.colFreight, "colFreight");
            this.colFreight.ColumnEdit = this.repositoryItemSpinEdit3;
            this.colFreight.DisplayFormat.FormatString = "c";
            this.colFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFreight.FieldName = "Freight";
            this.colFreight.Name = "colFreight";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AllowFocused = false;
            resources.ApplyResources(this.repositoryItemSpinEdit3, "repositoryItemSpinEdit3");
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // colShipName
            // 
            resources.ApplyResources(this.colShipName, "colShipName");
            this.colShipName.FieldName = "ShipName";
            this.colShipName.Name = "colShipName";
            // 
            // colShipAddress
            // 
            resources.ApplyResources(this.colShipAddress, "colShipAddress");
            this.colShipAddress.FieldName = "ShipAddress";
            this.colShipAddress.Name = "colShipAddress";
            // 
            // colShipCity
            // 
            resources.ApplyResources(this.colShipCity, "colShipCity");
            this.colShipCity.FieldName = "ShipCity";
            this.colShipCity.Name = "colShipCity";
            // 
            // colShipRegion
            // 
            resources.ApplyResources(this.colShipRegion, "colShipRegion");
            this.colShipRegion.FieldName = "ShipRegion";
            this.colShipRegion.Name = "colShipRegion";
            // 
            // colShipPostalCode
            // 
            resources.ApplyResources(this.colShipPostalCode, "colShipPostalCode");
            this.colShipPostalCode.FieldName = "ShipPostalCode";
            this.colShipPostalCode.Name = "colShipPostalCode";
            // 
            // colShipCountry
            // 
            resources.ApplyResources(this.colShipCountry, "colShipCountry");
            this.colShipCountry.FieldName = "ShipCountry";
            this.colShipCountry.Name = "colShipCountry";
            // 
            // gridControl2
            // 
            resources.ApplyResources(this.gridControl2, "gridControl2");
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Orders";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit3,
            this.repositoryItemImageComboBox3});
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl2.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl2_ViewRegistered);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.gridView1, "gridView1");
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
            this.gridView1.DetailHeight = 200;
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colContactTitle, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegion, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.EndGrouping += new System.EventHandler(this.gridView_EndGrouping);
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
            // 
            // colContactName
            // 
            resources.ApplyResources(this.colContactName, "colContactName");
            this.colContactName.FieldName = "ContactName";
            this.colContactName.ImageOptions.ImageIndex = ((int)(resources.GetObject("colContactName.ImageOptions.ImageIndex")));
            this.colContactName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colContactName.ImageOptions.SvgImage")));
            this.colContactName.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
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
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
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
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // colPhone
            // 
            resources.ApplyResources(this.colPhone, "colPhone");
            this.colPhone.FieldName = "Phone";
            this.colPhone.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colPhone.ImageOptions.SvgImage")));
            this.colPhone.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.colPhone.Name = "colPhone";
            // 
            // colFax
            // 
            resources.ApplyResources(this.colFax, "colFax");
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.chJoined);
            this.panelControl1.Controls.Add(this.chOwner);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // chJoined
            // 
            this.chJoined.AllowFocus = false;
            this.chJoined.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("chJoined.Appearance.Font")));
            this.chJoined.Appearance.Options.UseFont = true;
            this.chJoined.Appearance.Options.UseTextOptions = true;
            this.chJoined.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.chJoined.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chJoined.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("chJoined.ImageOptions.SvgImage")));
            resources.ApplyResources(this.chJoined, "chJoined");
            this.chJoined.Name = "chJoined";
            this.chJoined.Tag = "Merged Group Panel";
            this.chJoined.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
            // 
            // chOwner
            // 
            this.chOwner.AllowFocus = false;
            this.chOwner.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("chOwner.Appearance.Font")));
            this.chOwner.Appearance.Options.UseFont = true;
            this.chOwner.Appearance.Options.UseTextOptions = true;
            this.chOwner.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.chOwner.Checked = true;
            this.chOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("chOwner.ImageOptions.SvgImage")));
            resources.ApplyResources(this.chOwner, "chOwner");
            this.chOwner.Name = "chOwner";
            this.chOwner.Tag = "Separate Group Panels";
            this.chOwner.CheckedChanged += new System.EventHandler(this.ch_CheckedChanged);
            // 
            // MasterDetailGrouping
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "MasterDetailGrouping";
            this.Load += new System.EventHandler(this.MasterDetailGrouping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraGrid.Columns.GridColumn colShipVia;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
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
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShippedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraGrid.Columns.GridColumn colShipAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCity;
        private DevExpress.XtraGrid.Columns.GridColumn colShipRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colShipPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCountry;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckButton chOwner;
        private DevExpress.XtraEditors.CheckButton chJoined;

    }
}
