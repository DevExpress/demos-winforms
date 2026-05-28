namespace DevExpress.XtraLayout.Demos {
    partial class LayoutWaybill {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblcShipmentDetails = new DevExpress.XtraEditors.LabelControl();
            this.tedShipCountry = new DevExpress.XtraEditors.TextEdit();
            this.dsOrder = new DevExpress.XtraLayout.Demos.dsOrder();
            this.tedShipAddress = new DevExpress.XtraEditors.TextEdit();
            this.tedShipName = new DevExpress.XtraEditors.TextEdit();
            this.tedShipDate = new DevExpress.XtraEditors.TextEdit();
            this.pedLogo = new DevExpress.XtraEditors.PictureEdit();
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilProduct = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dnNavigationCustomer = new DevExpress.XtraEditors.DataNavigator();
            this.dnNavigationEmployee = new DevExpress.XtraEditors.DataNavigator();
            this.tedCountryEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedPostalCodeEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedRegionEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedCityEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedAddressEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedContactTitleEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedContactNameEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedCompanyNameEmployee = new DevExpress.XtraEditors.TextEdit();
            this.tedOrderID = new DevExpress.XtraEditors.TextEdit();
            this.tedOrderDate = new DevExpress.XtraEditors.TextEdit();
            this.dnNavigationOrders = new DevExpress.XtraEditors.DataNavigator();
            this.tedLastNameCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tedFirstNameCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tedAddressCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tedCityCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tedRegionCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tedPostalCodeCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tedCountryCustomer = new DevExpress.XtraEditors.TextEdit();
            this.tedTitleCustomer = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupOrderInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemOrderDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemNavigationOrder = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemOrderID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupInfoCustomer = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemLastNameCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAddressCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRegionCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemNavigationCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemFirstNameCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPostalCodeCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTitleCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCityCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCountryCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupInfoEmployee = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCompanyNameEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemContactNameEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAddressEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRegionEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemNavigationEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemCityEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPostalEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCountryEmployee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemContactTitleEmloyee = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupShipInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemShopDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemShopAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemShipCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.shipNameLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedShipCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedShipAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedShipName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedShipDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCountryEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedPostalCodeEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedRegionEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCityEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedAddressEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedContactTitleEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedContactNameEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCompanyNameEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedLastNameCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedFirstNameCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedAddressCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCityCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedRegionCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedPostalCodeCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCountryCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTitleCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupOrderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNavigationOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInfoCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLastNameCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAddressCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRegionCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNavigationCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFirstNameCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPostalCodeCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTitleCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCityCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountryCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInfoEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCompanyNameEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContactNameEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAddressEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRegionEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNavigationEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCityEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPostalEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountryEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContactTitleEmloyee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupShipInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShopDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShopAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShipCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipNameLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblcShipmentDetails);
            this.layoutControl1.Controls.Add(this.tedShipCountry);
            this.layoutControl1.Controls.Add(this.tedShipAddress);
            this.layoutControl1.Controls.Add(this.tedShipName);
            this.layoutControl1.Controls.Add(this.tedShipDate);
            this.layoutControl1.Controls.Add(this.pedLogo);
            this.layoutControl1.Controls.Add(this.gridOrders);
            this.layoutControl1.Controls.Add(this.dnNavigationCustomer);
            this.layoutControl1.Controls.Add(this.dnNavigationEmployee);
            this.layoutControl1.Controls.Add(this.tedCountryEmployee);
            this.layoutControl1.Controls.Add(this.tedPostalCodeEmployee);
            this.layoutControl1.Controls.Add(this.tedRegionEmployee);
            this.layoutControl1.Controls.Add(this.tedCityEmployee);
            this.layoutControl1.Controls.Add(this.tedAddressEmployee);
            this.layoutControl1.Controls.Add(this.tedContactTitleEmployee);
            this.layoutControl1.Controls.Add(this.tedContactNameEmployee);
            this.layoutControl1.Controls.Add(this.tedCompanyNameEmployee);
            this.layoutControl1.Controls.Add(this.tedOrderID);
            this.layoutControl1.Controls.Add(this.tedOrderDate);
            this.layoutControl1.Controls.Add(this.dnNavigationOrders);
            this.layoutControl1.Controls.Add(this.tedLastNameCustomer);
            this.layoutControl1.Controls.Add(this.tedFirstNameCustomer);
            this.layoutControl1.Controls.Add(this.tedAddressCustomer);
            this.layoutControl1.Controls.Add(this.tedCityCustomer);
            this.layoutControl1.Controls.Add(this.tedRegionCustomer);
            this.layoutControl1.Controls.Add(this.tedPostalCodeCustomer);
            this.layoutControl1.Controls.Add(this.tedCountryCustomer);
            this.layoutControl1.Controls.Add(this.tedTitleCustomer);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2214, 46, 956, 917);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(968, 619);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl2";
            // 
            // lblcShipmentDetails
            // 
            this.lblcShipmentDetails.Location = new System.Drawing.Point(24, 448);
            this.lblcShipmentDetails.Name = "lblcShipmentDetails";
            this.lblcShipmentDetails.Size = new System.Drawing.Size(94, 13);
            this.lblcShipmentDetails.StyleController = this.layoutControl1;
            this.lblcShipmentDetails.TabIndex = 47;
            this.lblcShipmentDetails.Text = "SHIPMENT DETAILS";
            // 
            // tedShipCountry
            // 
            this.tedShipCountry.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Orders.ShipCountry", true));
            this.tedShipCountry.EditValue = "";
            this.tedShipCountry.Location = new System.Drawing.Point(659, 38);
            this.tedShipCountry.Name = "tedShipCountry";
            this.tedShipCountry.Size = new System.Drawing.Size(295, 20);
            this.tedShipCountry.StyleController = this.layoutControl1;
            this.tedShipCountry.TabIndex = 34;
            // 
            // dsOrder
            // 
            this.dsOrder.DataSetName = "dsOrder";
            this.dsOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tedShipAddress
            // 
            this.tedShipAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Orders.ShipAddress", true));
            this.tedShipAddress.Location = new System.Drawing.Point(659, 62);
            this.tedShipAddress.Name = "tedShipAddress";
            this.tedShipAddress.Size = new System.Drawing.Size(295, 20);
            this.tedShipAddress.StyleController = this.layoutControl1;
            this.tedShipAddress.TabIndex = 33;
            // 
            // tedShipName
            // 
            this.tedShipName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Orders.ShipPostalCode", true));
            this.tedShipName.Location = new System.Drawing.Point(659, 86);
            this.tedShipName.Name = "tedShipName";
            this.tedShipName.Size = new System.Drawing.Size(295, 20);
            this.tedShipName.StyleController = this.layoutControl1;
            this.tedShipName.TabIndex = 32;
            // 
            // tedShipDate
            // 
            this.tedShipDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Orders.ShippedDate", true));
            this.tedShipDate.Location = new System.Drawing.Point(659, 14);
            this.tedShipDate.Name = "tedShipDate";
            this.tedShipDate.Properties.DisplayFormat.FormatString = "D";
            this.tedShipDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tedShipDate.Properties.Mask.EditMask = "D";
            this.tedShipDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tedShipDate.Size = new System.Drawing.Size(295, 20);
            this.tedShipDate.StyleController = this.layoutControl1;
            this.tedShipDate.TabIndex = 31;
            // 
            // pedLogo
            // 
            this.pedLogo.EditValue = global::DevExpress.XtraLayout.Demos.Properties.Resources.Logo;
            this.pedLogo.Location = new System.Drawing.Point(2, 2);
            this.pedLogo.Name = "pedLogo";
            this.pedLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pedLogo.Properties.Appearance.Options.UseBackColor = true;
            this.pedLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pedLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pedLogo.Size = new System.Drawing.Size(272, 116);
            this.pedLogo.StyleController = this.layoutControl1;
            this.pedLogo.TabIndex = 30;
            // 
            // gridOrders
            // 
            this.gridOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridOrders.DataSource = this.bindingSource;
            this.gridOrders.Location = new System.Drawing.Point(2, 466);
            this.gridOrders.MainView = this.gridViewOrders;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilProduct});
            this.gridOrders.Size = new System.Drawing.Size(964, 151);
            this.gridOrders.TabIndex = 29;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrders});
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataMember = "Order Details";
            this.bindingSource.DataSource = this.dsOrder;
            // 
            // gridViewOrders
            // 
            this.gridViewOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colUnitPrice,
            this.colQuantity,
            this.colDiscount,
            this.colProductName,
            this.colSubTotal});
            this.gridViewOrders.GridControl = this.gridOrders;
            this.gridViewOrders.Name = "gridViewOrders";
            this.gridViewOrders.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gridViewOrders.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewOrders.OptionsView.ShowFooter = true;
            this.gridViewOrders.OptionsView.ShowGroupPanel = false;
            this.gridViewOrders.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubTotal, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colOrderID
            // 
            this.colOrderID.Caption = "Shipment ID";
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 0;
            this.colOrderID.Width = 214;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DisplayFormat.FormatString = "c";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            this.colUnitPrice.Width = 226;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 165;
            // 
            // colDiscount
            // 
            this.colDiscount.DisplayFormat.FormatString = "p";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 4;
            this.colDiscount.Width = 154;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.ColumnEdit = this.rilProduct;
            this.colProductName.FieldName = "ProductID";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 208;
            // 
            // rilProduct
            // 
            this.rilProduct.AutoHeight = false;
            this.rilProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilProduct.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)});
            this.rilProduct.DisplayMember = "ProductName";
            this.rilProduct.DropDownRows = 12;
            this.rilProduct.Name = "rilProduct";
            this.rilProduct.ShowFooter = false;
            this.rilProduct.ShowHeader = false;
            this.rilProduct.ValueMember = "ProductID";
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub Total";
            this.colSubTotal.DisplayFormat.FormatString = "c";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "gridColumn1";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "Total = {0:c}")});
            this.colSubTotal.UnboundExpression = "[UnitPrice]*[Quantity]  * (1 - [Discount])";
            this.colSubTotal.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 5;
            this.colSubTotal.Width = 339;
            // 
            // dnNavigationCustomer
            // 
            this.dnNavigationCustomer.DataMember = "Employees";
            this.dnNavigationCustomer.DataSource = this.dsOrder;
            this.dnNavigationCustomer.Location = new System.Drawing.Point(14, 414);
            this.dnNavigationCustomer.Name = "dnNavigationCustomer";
            this.dnNavigationCustomer.Size = new System.Drawing.Size(228, 18);
            this.dnNavigationCustomer.StyleController = this.layoutControl1;
            this.dnNavigationCustomer.TabIndex = 28;
            this.dnNavigationCustomer.Text = "dataNavigator3";
            this.dnNavigationCustomer.Visible = false;
            // 
            // dnNavigationEmployee
            // 
            this.dnNavigationEmployee.DataMember = "Customers";
            this.dnNavigationEmployee.DataSource = this.dsOrder;
            this.dnNavigationEmployee.Location = new System.Drawing.Point(14, 251);
            this.dnNavigationEmployee.Name = "dnNavigationEmployee";
            this.dnNavigationEmployee.Size = new System.Drawing.Size(228, 18);
            this.dnNavigationEmployee.StyleController = this.layoutControl1;
            this.dnNavigationEmployee.TabIndex = 27;
            this.dnNavigationEmployee.Text = "dataNavigator2";
            this.dnNavigationEmployee.Visible = false;
            // 
            // tedCountryEmployee
            // 
            this.tedCountryEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.Country", true));
            this.tedCountryEmployee.Location = new System.Drawing.Point(714, 227);
            this.tedCountryEmployee.Name = "tedCountryEmployee";
            this.tedCountryEmployee.Size = new System.Drawing.Size(240, 20);
            this.tedCountryEmployee.StyleController = this.layoutControl1;
            this.tedCountryEmployee.TabIndex = 26;
            // 
            // tedPostalCodeEmployee
            // 
            this.tedPostalCodeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.PostalCode", true));
            this.tedPostalCodeEmployee.Location = new System.Drawing.Point(402, 227);
            this.tedPostalCodeEmployee.Name = "tedPostalCodeEmployee";
            this.tedPostalCodeEmployee.Size = new System.Drawing.Size(217, 20);
            this.tedPostalCodeEmployee.StyleController = this.layoutControl1;
            this.tedPostalCodeEmployee.TabIndex = 25;
            // 
            // tedRegionEmployee
            // 
            this.tedRegionEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.Region", true));
            this.tedRegionEmployee.Location = new System.Drawing.Point(105, 227);
            this.tedRegionEmployee.Name = "tedRegionEmployee";
            this.tedRegionEmployee.Size = new System.Drawing.Size(202, 20);
            this.tedRegionEmployee.StyleController = this.layoutControl1;
            this.tedRegionEmployee.TabIndex = 24;
            // 
            // tedCityEmployee
            // 
            this.tedCityEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.City", true));
            this.tedCityEmployee.Location = new System.Drawing.Point(714, 203);
            this.tedCityEmployee.Name = "tedCityEmployee";
            this.tedCityEmployee.Size = new System.Drawing.Size(240, 20);
            this.tedCityEmployee.StyleController = this.layoutControl1;
            this.tedCityEmployee.TabIndex = 23;
            // 
            // tedAddressEmployee
            // 
            this.tedAddressEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.Address", true));
            this.tedAddressEmployee.Location = new System.Drawing.Point(105, 203);
            this.tedAddressEmployee.Name = "tedAddressEmployee";
            this.tedAddressEmployee.Size = new System.Drawing.Size(514, 20);
            this.tedAddressEmployee.StyleController = this.layoutControl1;
            this.tedAddressEmployee.TabIndex = 22;
            // 
            // tedContactTitleEmployee
            // 
            this.tedContactTitleEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.ContactTitle", true));
            this.tedContactTitleEmployee.Location = new System.Drawing.Point(541, 179);
            this.tedContactTitleEmployee.Name = "tedContactTitleEmployee";
            this.tedContactTitleEmployee.Size = new System.Drawing.Size(413, 20);
            this.tedContactTitleEmployee.StyleController = this.layoutControl1;
            this.tedContactTitleEmployee.TabIndex = 21;
            // 
            // tedContactNameEmployee
            // 
            this.tedContactNameEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.ContactName", true));
            this.tedContactNameEmployee.Location = new System.Drawing.Point(105, 179);
            this.tedContactNameEmployee.Name = "tedContactNameEmployee";
            this.tedContactNameEmployee.Size = new System.Drawing.Size(341, 20);
            this.tedContactNameEmployee.StyleController = this.layoutControl1;
            this.tedContactNameEmployee.TabIndex = 20;
            // 
            // tedCompanyNameEmployee
            // 
            this.tedCompanyNameEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Customers.CompanyName", true));
            this.tedCompanyNameEmployee.Location = new System.Drawing.Point(105, 155);
            this.tedCompanyNameEmployee.Name = "tedCompanyNameEmployee";
            this.tedCompanyNameEmployee.Size = new System.Drawing.Size(849, 20);
            this.tedCompanyNameEmployee.StyleController = this.layoutControl1;
            this.tedCompanyNameEmployee.TabIndex = 19;
            // 
            // tedOrderID
            // 
            this.tedOrderID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Orders.OrderID", true));
            this.tedOrderID.Location = new System.Drawing.Point(381, 37);
            this.tedOrderID.Name = "tedOrderID";
            this.tedOrderID.Size = new System.Drawing.Size(159, 20);
            this.tedOrderID.StyleController = this.layoutControl1;
            this.tedOrderID.TabIndex = 18;
            // 
            // tedOrderDate
            // 
            this.tedOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Orders.OrderDate", true));
            this.tedOrderDate.Location = new System.Drawing.Point(381, 61);
            this.tedOrderDate.Name = "tedOrderDate";
            this.tedOrderDate.Properties.DisplayFormat.FormatString = "F";
            this.tedOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tedOrderDate.Properties.Mask.EditMask = "F";
            this.tedOrderDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tedOrderDate.Size = new System.Drawing.Size(159, 20);
            this.tedOrderDate.StyleController = this.layoutControl1;
            this.tedOrderDate.TabIndex = 17;
            // 
            // dnNavigationOrders
            // 
            this.dnNavigationOrders.Buttons.Append.Visible = false;
            this.dnNavigationOrders.Buttons.CancelEdit.Visible = false;
            this.dnNavigationOrders.Buttons.EndEdit.Visible = false;
            this.dnNavigationOrders.Buttons.First.Visible = false;
            this.dnNavigationOrders.Buttons.Last.Visible = false;
            this.dnNavigationOrders.Buttons.NextPage.Visible = false;
            this.dnNavigationOrders.Buttons.PrevPage.Visible = false;
            this.dnNavigationOrders.Buttons.Remove.Visible = false;
            this.dnNavigationOrders.DataMember = "Orders";
            this.dnNavigationOrders.DataSource = this.dsOrder;
            this.dnNavigationOrders.Location = new System.Drawing.Point(290, 14);
            this.dnNavigationOrders.MinimumSize = new System.Drawing.Size(250, 0);
            this.dnNavigationOrders.Name = "dnNavigationOrders";
            this.dnNavigationOrders.Size = new System.Drawing.Size(250, 19);
            this.dnNavigationOrders.StyleController = this.layoutControl1;
            this.dnNavigationOrders.TabIndex = 16;
            this.dnNavigationOrders.Text = "dataNavigator1";
            this.dnNavigationOrders.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dnNavigationOrders.PositionChanged += new System.EventHandler(this.dataNavigator1_PositionChanged);
            // 
            // tedLastNameCustomer
            // 
            this.tedLastNameCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.LastName", true));
            this.tedLastNameCustomer.Location = new System.Drawing.Point(541, 318);
            this.tedLastNameCustomer.Name = "tedLastNameCustomer";
            this.tedLastNameCustomer.Size = new System.Drawing.Size(413, 20);
            this.tedLastNameCustomer.StyleController = this.layoutControl1;
            this.tedLastNameCustomer.TabIndex = 19;
            // 
            // tedFirstNameCustomer
            // 
            this.tedFirstNameCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.FirstName", true));
            this.tedFirstNameCustomer.Location = new System.Drawing.Point(105, 318);
            this.tedFirstNameCustomer.Name = "tedFirstNameCustomer";
            this.tedFirstNameCustomer.Size = new System.Drawing.Size(341, 20);
            this.tedFirstNameCustomer.StyleController = this.layoutControl1;
            this.tedFirstNameCustomer.TabIndex = 20;
            // 
            // tedAddressCustomer
            // 
            this.tedAddressCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.Address", true));
            this.tedAddressCustomer.Location = new System.Drawing.Point(105, 366);
            this.tedAddressCustomer.Name = "tedAddressCustomer";
            this.tedAddressCustomer.Size = new System.Drawing.Size(514, 20);
            this.tedAddressCustomer.StyleController = this.layoutControl1;
            this.tedAddressCustomer.TabIndex = 21;
            // 
            // tedCityCustomer
            // 
            this.tedCityCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.City", true));
            this.tedCityCustomer.Location = new System.Drawing.Point(714, 366);
            this.tedCityCustomer.Name = "tedCityCustomer";
            this.tedCityCustomer.Size = new System.Drawing.Size(240, 20);
            this.tedCityCustomer.StyleController = this.layoutControl1;
            this.tedCityCustomer.TabIndex = 22;
            // 
            // tedRegionCustomer
            // 
            this.tedRegionCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.Region", true));
            this.tedRegionCustomer.Location = new System.Drawing.Point(105, 390);
            this.tedRegionCustomer.Name = "tedRegionCustomer";
            this.tedRegionCustomer.Size = new System.Drawing.Size(202, 20);
            this.tedRegionCustomer.StyleController = this.layoutControl1;
            this.tedRegionCustomer.TabIndex = 23;
            // 
            // tedPostalCodeCustomer
            // 
            this.tedPostalCodeCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.PostalCode", true));
            this.tedPostalCodeCustomer.Location = new System.Drawing.Point(402, 390);
            this.tedPostalCodeCustomer.Name = "tedPostalCodeCustomer";
            this.tedPostalCodeCustomer.Size = new System.Drawing.Size(217, 20);
            this.tedPostalCodeCustomer.StyleController = this.layoutControl1;
            this.tedPostalCodeCustomer.TabIndex = 24;
            // 
            // tedCountryCustomer
            // 
            this.tedCountryCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.Country", true));
            this.tedCountryCustomer.Location = new System.Drawing.Point(714, 390);
            this.tedCountryCustomer.Name = "tedCountryCustomer";
            this.tedCountryCustomer.Size = new System.Drawing.Size(240, 20);
            this.tedCountryCustomer.StyleController = this.layoutControl1;
            this.tedCountryCustomer.TabIndex = 25;
            // 
            // tedTitleCustomer
            // 
            this.tedTitleCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsOrder, "Employees.Title", true));
            this.tedTitleCustomer.Location = new System.Drawing.Point(105, 342);
            this.tedTitleCustomer.Name = "tedTitleCustomer";
            this.tedTitleCustomer.Size = new System.Drawing.Size(849, 20);
            this.tedTitleCustomer.StyleController = this.layoutControl1;
            this.tedTitleCustomer.TabIndex = 26;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupOrderInfo,
            this.layoutControlItemGrid,
            this.layoutControlGroupInfoCustomer,
            this.layoutControlGroupInfoEmployee,
            this.layoutControlGroupShipInfo,
            this.layoutControlItemLogo,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(968, 619);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroupOrderInfo
            // 
            this.layoutControlGroupOrderInfo.CustomizationFormText = "Shipment info";
            this.layoutControlGroupOrderInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemOrderDate,
            this.layoutControlItemNavigationOrder,
            this.layoutControlItemOrderID});
            this.layoutControlGroupOrderInfo.Location = new System.Drawing.Point(276, 0);
            this.layoutControlGroupOrderInfo.Name = "layoutControlGroupOrderInfo";
            this.layoutControlGroupOrderInfo.Size = new System.Drawing.Size(278, 120);
            this.layoutControlGroupOrderInfo.Text = "Shipment info";
            this.layoutControlGroupOrderInfo.TextVisible = false;
            // 
            // layoutControlItemOrderDate
            // 
            this.layoutControlItemOrderDate.Control = this.tedOrderDate;
            this.layoutControlItemOrderDate.CustomizationFormText = "Shipment date:";
            this.layoutControlItemOrderDate.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItemOrderDate.Name = "layoutControlItemOrderDate";
            this.layoutControlItemOrderDate.Size = new System.Drawing.Size(254, 49);
            this.layoutControlItemOrderDate.Text = "Shipment Date:";
            this.layoutControlItemOrderDate.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemNavigationOrder
            // 
            this.layoutControlItemNavigationOrder.Control = this.dnNavigationOrders;
            this.layoutControlItemNavigationOrder.CustomizationFormText = "NavigationShipment";
            this.layoutControlItemNavigationOrder.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemNavigationOrder.Name = "layoutControlItemNavigationOrder";
            this.layoutControlItemNavigationOrder.OptionsPrint.AllowPrint = false;
            this.layoutControlItemNavigationOrder.Size = new System.Drawing.Size(254, 23);
            this.layoutControlItemNavigationOrder.Text = "NavigationShipment";
            this.layoutControlItemNavigationOrder.TextVisible = false;
            // 
            // layoutControlItemOrderID
            // 
            this.layoutControlItemOrderID.Control = this.tedOrderID;
            this.layoutControlItemOrderID.CustomizationFormText = "Shipment ID:";
            this.layoutControlItemOrderID.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItemOrderID.Name = "layoutControlItemOrderID";
            this.layoutControlItemOrderID.Size = new System.Drawing.Size(254, 24);
            this.layoutControlItemOrderID.Text = "Shipment ID:";
            this.layoutControlItemOrderID.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemGrid
            // 
            this.layoutControlItemGrid.Control = this.gridOrders;
            this.layoutControlItemGrid.CustomizationFormText = "Shipment Details";
            this.layoutControlItemGrid.Location = new System.Drawing.Point(0, 464);
            this.layoutControlItemGrid.MinSize = new System.Drawing.Size(97, 137);
            this.layoutControlItemGrid.Name = "layoutControlItemGrid";
            this.layoutControlItemGrid.Size = new System.Drawing.Size(968, 155);
            this.layoutControlItemGrid.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemGrid.Text = "SHIPMENT DETAILS";
            this.layoutControlItemGrid.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItemGrid.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItemGrid.TextToControlDistance = 0;
            this.layoutControlItemGrid.TextVisible = false;
            // 
            // layoutControlGroupInfoCustomer
            // 
            this.layoutControlGroupInfoCustomer.CustomizationFormText = "to consignee";
            this.layoutControlGroupInfoCustomer.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemLastNameCustomer,
            this.layoutControlItemAddressCustomer,
            this.layoutControlItemRegionCustomer,
            this.layoutControlItemNavigationCustomer,
            this.emptySpaceItem6,
            this.layoutControlItemFirstNameCustomer,
            this.layoutControlItemPostalCodeCustomer,
            this.layoutControlItemTitleCustomer,
            this.layoutControlItemCityCustomer,
            this.layoutControlItemCountryCustomer});
            this.layoutControlGroupInfoCustomer.Location = new System.Drawing.Point(0, 283);
            this.layoutControlGroupInfoCustomer.Name = "layoutControlGroupInfoCustomer";
            this.layoutControlGroupInfoCustomer.Size = new System.Drawing.Size(968, 163);
            this.layoutControlGroupInfoCustomer.Text = "TO - CONSIGNEE";
            // 
            // layoutControlItemLastNameCustomer
            // 
            this.layoutControlItemLastNameCustomer.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemLastNameCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemLastNameCustomer.Control = this.tedLastNameCustomer;
            this.layoutControlItemLastNameCustomer.CustomizationFormText = "Last name:";
            this.layoutControlItemLastNameCustomer.Location = new System.Drawing.Point(436, 0);
            this.layoutControlItemLastNameCustomer.MinSize = new System.Drawing.Size(135, 22);
            this.layoutControlItemLastNameCustomer.Name = "layoutControlItemLastNameCustomer";
            this.layoutControlItemLastNameCustomer.Size = new System.Drawing.Size(508, 24);
            this.layoutControlItemLastNameCustomer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemLastNameCustomer.Text = "Last name:";
            this.layoutControlItemLastNameCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemAddressCustomer
            // 
            this.layoutControlItemAddressCustomer.Control = this.tedAddressCustomer;
            this.layoutControlItemAddressCustomer.CustomizationFormText = "Address:";
            this.layoutControlItemAddressCustomer.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemAddressCustomer.Name = "layoutControlItemAddressCustomer";
            this.layoutControlItemAddressCustomer.Size = new System.Drawing.Size(609, 24);
            this.layoutControlItemAddressCustomer.Text = "Address:";
            this.layoutControlItemAddressCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemRegionCustomer
            // 
            this.layoutControlItemRegionCustomer.Control = this.tedRegionCustomer;
            this.layoutControlItemRegionCustomer.CustomizationFormText = "Region:";
            this.layoutControlItemRegionCustomer.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemRegionCustomer.Name = "layoutControlItemRegionCustomer";
            this.layoutControlItemRegionCustomer.Size = new System.Drawing.Size(297, 24);
            this.layoutControlItemRegionCustomer.Text = "Region:";
            this.layoutControlItemRegionCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemNavigationCustomer
            // 
            this.layoutControlItemNavigationCustomer.Control = this.dnNavigationCustomer;
            this.layoutControlItemNavigationCustomer.CustomizationFormText = "NavigationCustomer";
            this.layoutControlItemNavigationCustomer.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItemNavigationCustomer.Name = "layoutControlItemNavigationCustomer";
            this.layoutControlItemNavigationCustomer.Size = new System.Drawing.Size(232, 22);
            this.layoutControlItemNavigationCustomer.Text = "NavigationCustomer";
            this.layoutControlItemNavigationCustomer.TextVisible = false;
            this.layoutControlItemNavigationCustomer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(232, 96);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(712, 22);
            this.emptySpaceItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItemFirstNameCustomer
            // 
            this.layoutControlItemFirstNameCustomer.Control = this.tedFirstNameCustomer;
            this.layoutControlItemFirstNameCustomer.CustomizationFormText = "First name:";
            this.layoutControlItemFirstNameCustomer.DataBindings.Add(new System.Windows.Forms.Binding("CustomizationFormText", this.dsOrder, "Employees.FirstName", true));
            this.layoutControlItemFirstNameCustomer.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemFirstNameCustomer.Name = "layoutControlItemFirstNameCustomer";
            this.layoutControlItemFirstNameCustomer.Size = new System.Drawing.Size(436, 24);
            this.layoutControlItemFirstNameCustomer.Text = "First name:";
            this.layoutControlItemFirstNameCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemPostalCodeCustomer
            // 
            this.layoutControlItemPostalCodeCustomer.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemPostalCodeCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemPostalCodeCustomer.Control = this.tedPostalCodeCustomer;
            this.layoutControlItemPostalCodeCustomer.CustomizationFormText = "Postal code:";
            this.layoutControlItemPostalCodeCustomer.Location = new System.Drawing.Point(297, 72);
            this.layoutControlItemPostalCodeCustomer.Name = "layoutControlItemPostalCodeCustomer";
            this.layoutControlItemPostalCodeCustomer.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItemPostalCodeCustomer.Text = "Postal code:";
            this.layoutControlItemPostalCodeCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemTitleCustomer
            // 
            this.layoutControlItemTitleCustomer.Control = this.tedTitleCustomer;
            this.layoutControlItemTitleCustomer.CustomizationFormText = "Title:";
            this.layoutControlItemTitleCustomer.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemTitleCustomer.Name = "layoutControlItemTitleCustomer";
            this.layoutControlItemTitleCustomer.Size = new System.Drawing.Size(944, 24);
            this.layoutControlItemTitleCustomer.Text = "Title:";
            this.layoutControlItemTitleCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemCityCustomer
            // 
            this.layoutControlItemCityCustomer.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemCityCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemCityCustomer.Control = this.tedCityCustomer;
            this.layoutControlItemCityCustomer.CustomizationFormText = "City:";
            this.layoutControlItemCityCustomer.Location = new System.Drawing.Point(609, 48);
            this.layoutControlItemCityCustomer.Name = "layoutControlItemCityCustomer";
            this.layoutControlItemCityCustomer.Size = new System.Drawing.Size(335, 24);
            this.layoutControlItemCityCustomer.Text = "City:";
            this.layoutControlItemCityCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemCountryCustomer
            // 
            this.layoutControlItemCountryCustomer.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemCountryCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemCountryCustomer.Control = this.tedCountryCustomer;
            this.layoutControlItemCountryCustomer.CustomizationFormText = "Country:";
            this.layoutControlItemCountryCustomer.Location = new System.Drawing.Point(609, 72);
            this.layoutControlItemCountryCustomer.Name = "layoutControlItemCountryCustomer";
            this.layoutControlItemCountryCustomer.Size = new System.Drawing.Size(335, 24);
            this.layoutControlItemCountryCustomer.Text = "Country:";
            this.layoutControlItemCountryCustomer.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlGroupInfoEmployee
            // 
            this.layoutControlGroupInfoEmployee.CustomizationFormText = "Shipment from";
            this.layoutControlGroupInfoEmployee.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemCompanyNameEmployee,
            this.layoutControlItemContactNameEmployee,
            this.layoutControlItemAddressEmployee,
            this.layoutControlItemRegionEmployee,
            this.layoutControlItemNavigationEmployee,
            this.emptySpaceItem3,
            this.layoutControlItemCityEmployee,
            this.layoutControlItemPostalEmployee,
            this.layoutControlItemCountryEmployee,
            this.layoutControlItemContactTitleEmloyee});
            this.layoutControlGroupInfoEmployee.Location = new System.Drawing.Point(0, 120);
            this.layoutControlGroupInfoEmployee.Name = "layoutControlGroupInfoEmployee";
            this.layoutControlGroupInfoEmployee.Size = new System.Drawing.Size(968, 163);
            this.layoutControlGroupInfoEmployee.Text = "SHIPMENT FROM";
            // 
            // layoutControlItemCompanyNameEmployee
            // 
            this.layoutControlItemCompanyNameEmployee.Control = this.tedCompanyNameEmployee;
            this.layoutControlItemCompanyNameEmployee.CustomizationFormText = "Company name:";
            this.layoutControlItemCompanyNameEmployee.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemCompanyNameEmployee.Name = "layoutControlItemCompanyNameEmployee";
            this.layoutControlItemCompanyNameEmployee.Size = new System.Drawing.Size(944, 24);
            this.layoutControlItemCompanyNameEmployee.Text = "Company Name:";
            this.layoutControlItemCompanyNameEmployee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemContactNameEmployee
            // 
            this.layoutControlItemContactNameEmployee.Control = this.tedContactNameEmployee;
            this.layoutControlItemContactNameEmployee.CustomizationFormText = "Contact name:";
            this.layoutControlItemContactNameEmployee.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemContactNameEmployee.Name = "layoutControlItemContactNameEmployee";
            this.layoutControlItemContactNameEmployee.Size = new System.Drawing.Size(436, 24);
            this.layoutControlItemContactNameEmployee.Text = "Contact Name:";
            this.layoutControlItemContactNameEmployee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemAddressEmployee
            // 
            this.layoutControlItemAddressEmployee.Control = this.tedAddressEmployee;
            this.layoutControlItemAddressEmployee.CustomizationFormText = "Address:";
            this.layoutControlItemAddressEmployee.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemAddressEmployee.Name = "layoutControlItemAddressEmployee";
            this.layoutControlItemAddressEmployee.Size = new System.Drawing.Size(609, 24);
            this.layoutControlItemAddressEmployee.Text = "Address:";
            this.layoutControlItemAddressEmployee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemRegionEmployee
            // 
            this.layoutControlItemRegionEmployee.Control = this.tedRegionEmployee;
            this.layoutControlItemRegionEmployee.CustomizationFormText = "Region:";
            this.layoutControlItemRegionEmployee.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemRegionEmployee.Name = "layoutControlItemRegionEmployee";
            this.layoutControlItemRegionEmployee.Size = new System.Drawing.Size(297, 24);
            this.layoutControlItemRegionEmployee.Text = "Region:";
            this.layoutControlItemRegionEmployee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemNavigationEmployee
            // 
            this.layoutControlItemNavigationEmployee.Control = this.dnNavigationEmployee;
            this.layoutControlItemNavigationEmployee.CustomizationFormText = "NavigationEmployee";
            this.layoutControlItemNavigationEmployee.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItemNavigationEmployee.Name = "layoutControlItemNavigationEmployee";
            this.layoutControlItemNavigationEmployee.Size = new System.Drawing.Size(232, 22);
            this.layoutControlItemNavigationEmployee.Text = "NavigationEmployee";
            this.layoutControlItemNavigationEmployee.TextVisible = false;
            this.layoutControlItemNavigationEmployee.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(232, 96);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(712, 22);
            this.emptySpaceItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItemCityEmployee
            // 
            this.layoutControlItemCityEmployee.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemCityEmployee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemCityEmployee.Control = this.tedCityEmployee;
            this.layoutControlItemCityEmployee.CustomizationFormText = "City:";
            this.layoutControlItemCityEmployee.Location = new System.Drawing.Point(609, 48);
            this.layoutControlItemCityEmployee.Name = "layoutControlItemCityEmployee";
            this.layoutControlItemCityEmployee.Size = new System.Drawing.Size(335, 24);
            this.layoutControlItemCityEmployee.Text = "City:";
            this.layoutControlItemCityEmployee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemPostalEmployee
            // 
            this.layoutControlItemPostalEmployee.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemPostalEmployee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemPostalEmployee.Control = this.tedPostalCodeEmployee;
            this.layoutControlItemPostalEmployee.CustomizationFormText = "Postal code:";
            this.layoutControlItemPostalEmployee.Location = new System.Drawing.Point(297, 72);
            this.layoutControlItemPostalEmployee.Name = "layoutControlItemPostalEmployee";
            this.layoutControlItemPostalEmployee.Size = new System.Drawing.Size(312, 24);
            this.layoutControlItemPostalEmployee.Text = "Postal code:";
            this.layoutControlItemPostalEmployee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemCountryEmployee
            // 
            this.layoutControlItemCountryEmployee.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemCountryEmployee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemCountryEmployee.Control = this.tedCountryEmployee;
            this.layoutControlItemCountryEmployee.CustomizationFormText = "Country:";
            this.layoutControlItemCountryEmployee.Location = new System.Drawing.Point(609, 72);
            this.layoutControlItemCountryEmployee.Name = "layoutControlItemCountryEmployee";
            this.layoutControlItemCountryEmployee.Size = new System.Drawing.Size(335, 24);
            this.layoutControlItemCountryEmployee.Text = "Country:";
            this.layoutControlItemCountryEmployee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemContactTitleEmloyee
            // 
            this.layoutControlItemContactTitleEmloyee.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemContactTitleEmloyee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItemContactTitleEmloyee.Control = this.tedContactTitleEmployee;
            this.layoutControlItemContactTitleEmloyee.CustomizationFormText = "Contact title:";
            this.layoutControlItemContactTitleEmloyee.Location = new System.Drawing.Point(436, 24);
            this.layoutControlItemContactTitleEmloyee.Name = "layoutControlItemContactTitleEmloyee";
            this.layoutControlItemContactTitleEmloyee.Size = new System.Drawing.Size(508, 24);
            this.layoutControlItemContactTitleEmloyee.Text = "Contact Title:";
            this.layoutControlItemContactTitleEmloyee.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlGroupShipInfo
            // 
            this.layoutControlGroupShipInfo.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroupShipInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemShopDate,
            this.layoutControlItemShopAddress,
            this.layoutControlItemShipCountry,
            this.shipNameLCI});
            this.layoutControlGroupShipInfo.Location = new System.Drawing.Point(554, 0);
            this.layoutControlGroupShipInfo.Name = "layoutControlGroupShipInfo";
            this.layoutControlGroupShipInfo.Size = new System.Drawing.Size(414, 120);
            this.layoutControlGroupShipInfo.TextVisible = false;
            // 
            // layoutControlItemShopDate
            // 
            this.layoutControlItemShopDate.Control = this.tedShipDate;
            this.layoutControlItemShopDate.CustomizationFormText = "Ship Date:";
            this.layoutControlItemShopDate.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemShopDate.Name = "layoutControlItemShopDate";
            this.layoutControlItemShopDate.Size = new System.Drawing.Size(390, 24);
            this.layoutControlItemShopDate.Text = "Ship Date:";
            this.layoutControlItemShopDate.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemShopAddress
            // 
            this.layoutControlItemShopAddress.Control = this.tedShipAddress;
            this.layoutControlItemShopAddress.CustomizationFormText = "Ship Address:";
            this.layoutControlItemShopAddress.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemShopAddress.Name = "layoutControlItemShopAddress";
            this.layoutControlItemShopAddress.Size = new System.Drawing.Size(390, 24);
            this.layoutControlItemShopAddress.Text = "Ship Address:";
            this.layoutControlItemShopAddress.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemShipCountry
            // 
            this.layoutControlItemShipCountry.Control = this.tedShipCountry;
            this.layoutControlItemShipCountry.CustomizationFormText = "Ship Country:";
            this.layoutControlItemShipCountry.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemShipCountry.Name = "layoutControlItemShipCountry";
            this.layoutControlItemShipCountry.Size = new System.Drawing.Size(390, 24);
            this.layoutControlItemShipCountry.Text = "Ship Country:";
            this.layoutControlItemShipCountry.TextSize = new System.Drawing.Size(79, 13);
            // 
            // shipNameLCI
            // 
            this.shipNameLCI.Control = this.tedShipName;
            this.shipNameLCI.CustomizationFormText = "layoutControlItem2";
            this.shipNameLCI.Location = new System.Drawing.Point(0, 72);
            this.shipNameLCI.Name = "shipNameLCI";
            this.shipNameLCI.Size = new System.Drawing.Size(390, 24);
            this.shipNameLCI.Text = "Ship Name:";
            this.shipNameLCI.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItemLogo
            // 
            this.layoutControlItemLogo.Control = this.pedLogo;
            this.layoutControlItemLogo.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItemLogo.CustomizationFormText = "Logo";
            this.layoutControlItemLogo.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItemLogo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemLogo.MaxSize = new System.Drawing.Size(276, 120);
            this.layoutControlItemLogo.MinSize = new System.Drawing.Size(276, 120);
            this.layoutControlItemLogo.Name = "layoutControlItemLogo";
            this.layoutControlItemLogo.Size = new System.Drawing.Size(276, 120);
            this.layoutControlItemLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemLogo.Text = "Logo";
            this.layoutControlItemLogo.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblcShipmentDetails;
            this.layoutControlItem1.CustomizationFormText = "lciShipmentDetails";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 446);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 2, 2, 3);
            this.layoutControlItem1.Size = new System.Drawing.Size(968, 18);
            this.layoutControlItem1.Text = "Shipment Details";
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(968, 731);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // LayoutWaybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "LayoutWaybill";
            this.Size = new System.Drawing.Size(968, 619);
            this.Load += new System.EventHandler(this.LayoutWaybill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tedShipCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedShipAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedShipName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedShipDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCountryEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedPostalCodeEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedRegionEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCityEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedAddressEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedContactTitleEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedContactNameEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCompanyNameEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedLastNameCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedFirstNameCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedAddressCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCityCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedRegionCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedPostalCodeCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedCountryCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTitleCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupOrderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNavigationOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInfoCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLastNameCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAddressCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRegionCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNavigationCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFirstNameCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPostalCodeCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTitleCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCityCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountryCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInfoEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCompanyNameEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContactNameEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAddressEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRegionEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNavigationEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCityEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPostalEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountryEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemContactTitleEmloyee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupShipInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShopDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShopAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShipCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipNameLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LayoutControlGroup layoutControlGroup1;
        private dsOrder dsOrder;
        private LayoutControlItem layoutControlItemNavigationOrder;
        private XtraEditors.TextEdit tedCountryEmployee;
        private XtraEditors.TextEdit tedPostalCodeEmployee;
        private XtraEditors.TextEdit tedRegionEmployee;
        private XtraEditors.TextEdit tedCityEmployee;
        private XtraEditors.TextEdit tedAddressEmployee;
        private XtraEditors.TextEdit tedContactTitleEmployee;
        private XtraEditors.TextEdit tedContactNameEmployee;
        private XtraEditors.TextEdit tedCompanyNameEmployee;
        private XtraEditors.TextEdit tedOrderID;
        private XtraEditors.TextEdit tedOrderDate;
        private LayoutControlGroup layoutControlGroupOrderInfo;
        private LayoutControlItem layoutControlItemOrderID;
        private LayoutControlItem layoutControlItemOrderDate;
        private XtraEditors.TextEdit tedLastNameCustomer;
        private XtraEditors.TextEdit tedFirstNameCustomer;
        private XtraEditors.TextEdit tedAddressCustomer;
        private XtraEditors.TextEdit tedCityCustomer;
        private XtraEditors.TextEdit tedRegionCustomer;
        private XtraEditors.TextEdit tedPostalCodeCustomer;
        private XtraEditors.TextEdit tedCountryCustomer;
        private XtraEditors.TextEdit tedTitleCustomer;
        private XtraEditors.DataNavigator dnNavigationCustomer;
        private XtraEditors.DataNavigator dnNavigationEmployee;
        private XtraGrid.GridControl gridOrders;
        private System.Windows.Forms.BindingSource bindingSource;
        private XtraGrid.Views.Grid.GridView gridViewOrders;
        private LayoutControlItem layoutControlItemGrid;
        private XtraGrid.Columns.GridColumn colOrderID;
        private XtraGrid.Columns.GridColumn colUnitPrice;
        private XtraGrid.Columns.GridColumn colQuantity;
        private XtraGrid.Columns.GridColumn colDiscount;
        private XtraGrid.Columns.GridColumn colProductName;
        private LayoutControlItem layoutControlItemLogo;
        private LayoutControlGroup layoutControlGroupInfoCustomer;
        private LayoutControlItem layoutControlItemLastNameCustomer;
        private LayoutControlItem layoutControlItemAddressCustomer;
        private LayoutControlItem layoutControlItemRegionCustomer;
        private LayoutControlItem layoutControlItemNavigationCustomer;
        private EmptySpaceItem emptySpaceItem6;
        private LayoutControlItem layoutControlItemFirstNameCustomer;
        private LayoutControlItem layoutControlItemPostalCodeCustomer;
        private LayoutControlItem layoutControlItemTitleCustomer;
        private LayoutControlItem layoutControlItemCityCustomer;
        private LayoutControlItem layoutControlItemCountryCustomer;
        private LayoutControlGroup layoutControlGroupInfoEmployee;
        private LayoutControlItem layoutControlItemCompanyNameEmployee;
        private LayoutControlItem layoutControlItemContactNameEmployee;
        private LayoutControlItem layoutControlItemAddressEmployee;
        private LayoutControlItem layoutControlItemRegionEmployee;
        private LayoutControlItem layoutControlItemNavigationEmployee;
        private EmptySpaceItem emptySpaceItem3;
        private LayoutControlItem layoutControlItemCityEmployee;
        private LayoutControlItem layoutControlItemPostalEmployee;
        private LayoutControlItem layoutControlItemCountryEmployee;
        private LayoutControlItem layoutControlItemContactTitleEmloyee;
        private XtraEditors.TextEdit tedShipDate;
        private LayoutControlItem layoutControlItemShopDate;
        private XtraEditors.TextEdit tedShipAddress;
        private XtraEditors.TextEdit tedShipName;
        private LayoutControlGroup layoutControlGroupShipInfo;
        private LayoutControlItem shipNameLCI;
        private LayoutControlItem layoutControlItemShopAddress;
        private XtraEditors.TextEdit tedShipCountry;
        private LayoutControlItem layoutControlItemShipCountry;
        private XtraGrid.Columns.GridColumn colSubTotal;
        public XtraEditors.DataNavigator dnNavigationOrders;
        private LayoutControlGroup layoutControlGroup2;
        public LayoutControl layoutControl1;
        private XtraEditors.LabelControl lblcShipmentDetails;
        private LayoutControlItem layoutControlItem1;
        public XtraEditors.PictureEdit pedLogo;
        private XtraEditors.Repository.RepositoryItemLookUpEdit rilProduct;
    }
}
