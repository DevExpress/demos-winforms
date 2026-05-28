namespace DevExpress.XtraSpreadsheet.Demos {
    partial class BindingToDataSourceModule {
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindingToDataSourceModule));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.lbBindToData = new DevExpress.XtraEditors.LabelControl();
            this.cbxBindToData = new DevExpress.XtraEditors.ComboBoxEdit();
            this.edOrderId = new DevExpress.XtraEditors.LookUpEdit();
            this.chbDiscount = new DevExpress.XtraEditors.CheckEdit();
            this.lbOrderId = new DevExpress.XtraEditors.LabelControl();
            this.lbProduct = new DevExpress.XtraEditors.LabelControl();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.edProductName = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBindToData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOrderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.UseSkinColors = false;
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.Print.PrintContent = DevExpress.XtraSpreadsheet.SpreadsheetPrintContent.ActiveSheets;
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            resources.ApplyResources(this.spreadsheetControl1, "spreadsheetControl1");
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = resources.GetString("ribbonControl1.SearchEditItem.AccessibleName");
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = ((int)(resources.GetObject("ribbonControl1.SearchEditItem.EditWidth")));
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Controls.Add(this.layoutControl1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // lbBindToData
            // 
            resources.ApplyResources(this.lbBindToData, "lbBindToData");
            this.lbBindToData.Name = "lbBindToData";
            this.lbBindToData.StyleController = this.layoutControl1;
            // 
            // cbxBindToData
            // 
            resources.ApplyResources(this.cbxBindToData, "cbxBindToData");
            this.cbxBindToData.Name = "cbxBindToData";
            this.cbxBindToData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbxBindToData.Properties.Buttons"))))});
            this.cbxBindToData.Properties.DropDownRows = 2;
            this.cbxBindToData.Properties.Items.AddRange(new object[] {
            resources.GetString("cbxBindToData.Properties.Items"),
            resources.GetString("cbxBindToData.Properties.Items1")});
            this.cbxBindToData.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxBindToData.StyleController = this.layoutControl1;
            this.cbxBindToData.SelectedIndexChanged += new System.EventHandler(this.BindToData_SelectedIndexChanged);
            // 
            // edOrderId
            // 
            resources.ApplyResources(this.edOrderId, "edOrderId");
            this.edOrderId.MenuManager = this.ribbonControl1;
            this.edOrderId.Name = "edOrderId";
            this.edOrderId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.edOrderId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edOrderId.Properties.Buttons"))))});
            this.edOrderId.Properties.NullText = resources.GetString("edOrderId.Properties.NullText");
            this.edOrderId.Properties.PopupFormMinSize = new System.Drawing.Size(140, 0);
            this.edOrderId.Properties.ShowFooter = false;
            this.edOrderId.Properties.ShowHeader = false;
            this.edOrderId.StyleController = this.layoutControl1;
            this.edOrderId.EditValueChanged += new System.EventHandler(this.OrderId_EditValueChanged);
            // 
            // chbDiscount
            // 
            resources.ApplyResources(this.chbDiscount, "chbDiscount");
            this.chbDiscount.MenuManager = this.ribbonControl1;
            this.chbDiscount.Name = "chbDiscount";
            this.chbDiscount.Properties.Caption = resources.GetString("chbDiscount.Properties.Caption");
            this.chbDiscount.StyleController = this.layoutControl1;
            this.chbDiscount.CheckedChanged += new System.EventHandler(this.Discount_CheckedChanged);
            // 
            // lbOrderId
            // 
            resources.ApplyResources(this.lbOrderId, "lbOrderId");
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.StyleController = this.layoutControl1;
            // 
            // lbProduct
            // 
            resources.ApplyResources(this.lbProduct, "lbProduct");
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.StyleController = this.layoutControl1;
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.StyleController = this.layoutControl1;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // edProductName
            // 
            resources.ApplyResources(this.edProductName, "edProductName");
            this.edProductName.MenuManager = this.ribbonControl1;
            this.edProductName.Name = "edProductName";
            this.edProductName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.edProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edProductName.Properties.Buttons"))))});
            this.edProductName.Properties.NullText = resources.GetString("edProductName.Properties.NullText");
            this.edProductName.Properties.ShowFooter = false;
            this.edProductName.Properties.ShowHeader = false;
            this.edProductName.StyleController = this.layoutControl1;
            this.edProductName.EditValueChanged += new System.EventHandler(this.ProductName_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.cbxBindToData);
            this.layoutControl1.Controls.Add(this.lbBindToData);
            this.layoutControl1.Controls.Add(this.edProductName);
            this.layoutControl1.Controls.Add(this.lbProduct);
            this.layoutControl1.Controls.Add(this.chbDiscount);
            this.layoutControl1.Controls.Add(this.btnReset);
            this.layoutControl1.Controls.Add(this.edOrderId);
            this.layoutControl1.Controls.Add(this.lbOrderId);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(864, 104, 791, 596);
            this.layoutControl1.Root = this.Root;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition1.Width = 68D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 25D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition4.Width = 115D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 3D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition4.Height = 3D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 26D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition6.Height = 10D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition8.Height = 217D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7,
            rowDefinition8});
            this.Root.Size = new System.Drawing.Size(248, 351);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem1.Control = this.lbOrderId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(68, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.edOrderId;
            this.layoutControlItem2.Location = new System.Drawing.Point(88, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem3.Control = this.chbDiscount;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem3.Size = new System.Drawing.Size(68, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.btnReset;
            this.layoutControlItem4.Location = new System.Drawing.Point(113, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem4.Size = new System.Drawing.Size(115, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem5.Control = this.lbProduct;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(68, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.edProductName;
            this.layoutControlItem6.Location = new System.Drawing.Point(88, 27);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem6.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem7.Control = this.lbBindToData;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem7.Size = new System.Drawing.Size(68, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem8.Control = this.cbxBindToData;
            this.layoutControlItem8.Location = new System.Drawing.Point(88, 90);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem8.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // BindingToDataSourceModule
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Name = "BindingToDataSourceModule";
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.sidePanel1, 0);
            this.Controls.SetChildIndex(this.spreadsheetControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxBindToData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOrderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private XtraEditors.SidePanel sidePanel1;
        private XtraEditors.LabelControl lbBindToData;
        private XtraEditors.ComboBoxEdit cbxBindToData;
        private XtraEditors.LookUpEdit edOrderId;
        private XtraEditors.CheckEdit chbDiscount;
        private XtraEditors.LabelControl lbOrderId;
        private XtraEditors.LabelControl lbProduct;
        private XtraEditors.SimpleButton btnReset;
        private XtraEditors.LookUpEdit edProductName;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
    }
}
