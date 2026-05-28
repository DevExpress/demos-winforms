namespace DevExpress.XtraEditors.Demos {
    partial class ModuleLookUpEdit {
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
            this.notePanel1 = new DevExpress.DXperience.Demos.DescriptionLabel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.notePanel2 = new DevExpress.DXperience.Demos.DescriptionLabel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.notePanel3 = new DevExpress.DXperience.Demos.DescriptionLabel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.notePanel4 = new DevExpress.DXperience.Demos.DescriptionLabel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.properties = new DevExpress.XtraEditors.Demos.LookUpProperties();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notePanel1
            // 
            this.notePanel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.notePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notePanel1.Location = new System.Drawing.Point(17, 493);
            this.notePanel1.Name = "notePanel1";
            this.notePanel1.Size = new System.Drawing.Size(467, 0);
            this.notePanel1.TabIndex = 4;
            this.notePanel1.Visible = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(17, 493);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(467, 12);
            this.panelControl3.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lookUpEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(17, 17);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(17);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.panelControl1.Size = new System.Drawing.Size(467, 204);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Text = "Sample";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit1.Location = new System.Drawing.Point(22, 83);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QuantityPerUnit", "Quantity Per Unit", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitPrice", "Unit Price", 30, DevExpress.Utils.FormatType.Numeric, "c", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Discontinued", "Discontinued", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DisplayMember = "ProductName";
            this.lookUpEdit1.Properties.DropDownRows = 15;
            this.lookUpEdit1.Properties.PopupWidth = 500;
            this.lookUpEdit1.Properties.ValueMember = "ProductID";
            this.lookUpEdit1.Size = new System.Drawing.Size(423, 20);
            this.lookUpEdit1.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(17, 505);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(467, 21);
            this.dataNavigator1.TabIndex = 5;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.lookUpEdit2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(17, 17);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.groupControl1.Size = new System.Drawing.Size(467, 204);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Sample";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit2.Location = new System.Drawing.Point(22, 83);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurchaseDate", "Purchase Date", 30, DevExpress.Utils.FormatType.DateTime, "D", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentAmount", "Payment Amount", 20, DevExpress.Utils.FormatType.Numeric, "c", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit2.Properties.DisplayMember = "Name";
            this.lookUpEdit2.Properties.DropDownRows = 5;
            this.lookUpEdit2.Properties.PopupWidth = 400;
            this.lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit2.Properties.ValueMember = "ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(423, 20);
            this.lookUpEdit2.TabIndex = 0;
            // 
            // notePanel2
            // 
            this.notePanel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.notePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notePanel2.Location = new System.Drawing.Point(17, 526);
            this.notePanel2.Name = "notePanel2";
            this.notePanel2.Size = new System.Drawing.Size(467, 0);
            this.notePanel2.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.lookUpEdit3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(17, 17);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.groupControl2.Size = new System.Drawing.Size(467, 204);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Sample";
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit3.Location = new System.Drawing.Point(22, 83);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.DropDownRows = 20;
            this.lookUpEdit3.Properties.PopupWidth = 200;
            this.lookUpEdit3.Size = new System.Drawing.Size(423, 20);
            this.lookUpEdit3.TabIndex = 0;
            // 
            // notePanel3
            // 
            this.notePanel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.notePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notePanel3.Location = new System.Drawing.Point(17, 526);
            this.notePanel3.Name = "notePanel3";
            this.notePanel3.Size = new System.Drawing.Size(467, 0);
            this.notePanel3.TabIndex = 5;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.Controls.Add(this.lookUpEdit4);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(17, 17);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.groupControl3.Size = new System.Drawing.Size(467, 204);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "Sample";
            // 
            // lookUpEdit4
            // 
            this.lookUpEdit4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit4.Location = new System.Drawing.Point(22, 83);
            this.lookUpEdit4.Name = "lookUpEdit4";
            this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NotInList", "# (Not In List Column)", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country")});
            this.lookUpEdit4.Properties.DisplayMember = "Country";
            this.lookUpEdit4.Properties.DropDownRows = 20;
            this.lookUpEdit4.Properties.PopupWidth = 300;
            this.lookUpEdit4.Properties.ValueMember = "Country";
            this.lookUpEdit4.Size = new System.Drawing.Size(423, 20);
            this.lookUpEdit4.TabIndex = 0;
            // 
            // notePanel4
            // 
            this.notePanel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.notePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notePanel4.Location = new System.Drawing.Point(17, 526);
            this.notePanel4.Name = "notePanel4";
            this.notePanel4.Size = new System.Drawing.Size(467, 0);
            this.notePanel4.TabIndex = 5;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(501, 576);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(501, 576);
            this.tabPane1.TabIndex = 1;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Data Binding";
            this.tabNavigationPage1.Controls.Add(this.notePanel1);
            this.tabNavigationPage1.Controls.Add(this.panelControl3);
            this.tabNavigationPage1.Controls.Add(this.panelControl1);
            this.tabNavigationPage1.Controls.Add(this.dataNavigator1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Padding = new System.Windows.Forms.Padding(17);
            this.tabNavigationPage1.Size = new System.Drawing.Size(501, 543);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Simple Binding";
            this.tabNavigationPage2.Controls.Add(this.groupControl1);
            this.tabNavigationPage2.Controls.Add(this.notePanel2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Padding = new System.Windows.Forms.Padding(17);
            this.tabNavigationPage2.Size = new System.Drawing.Size(501, 543);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Array Binding";
            this.tabNavigationPage3.Controls.Add(this.groupControl2);
            this.tabNavigationPage3.Controls.Add(this.notePanel3);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Padding = new System.Windows.Forms.Padding(17);
            this.tabNavigationPage3.Size = new System.Drawing.Size(501, 543);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Not In List";
            this.tabNavigationPage4.Controls.Add(this.groupControl3);
            this.tabNavigationPage4.Controls.Add(this.notePanel4);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Padding = new System.Windows.Forms.Padding(17);
            this.tabNavigationPage4.Size = new System.Drawing.Size(501, 543);
            // 
            // properties
            // 
            this.properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.properties.Location = new System.Drawing.Point(1, 0);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(314, 576);
            this.properties.TabIndex = 0;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.properties);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(501, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(315, 576);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // ModuleLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "ModuleLookUpEdit";
            this.Size = new System.Drawing.Size(816, 576);
            this.Load += new System.EventHandler(this.ModuleLookUpEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage4.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl panelControl1;
        private DXperience.Demos.DescriptionLabel notePanel1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DXperience.Demos.DescriptionLabel notePanel2;
        private DXperience.Demos.DescriptionLabel notePanel3;
        private DXperience.Demos.DescriptionLabel notePanel4;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit4;
        private System.ComponentModel.IContainer components = null;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraEditors.Demos.LookUpProperties properties;
        private SidePanel sidePanel1;
    }
}
