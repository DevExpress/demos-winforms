namespace DevExpress.Xpo.Demos
{
    partial class XPViewDemo {
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
            this.xpviewSuppliersProduct = new DevExpress.Xpo.XPView(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.cbViews = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.xpviewProducts = new DevExpress.Xpo.XPView(this.components);
            this.xpviewOrders = new DevExpress.Xpo.XPView(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xpviewSuppliersProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbViews.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpviewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpviewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // xpviewSuppliersProduct
            // 
            this.xpviewSuppliersProduct.ObjectType = typeof(DevExpress.Xpo.Demos.Tutorials.Suppliers);
            this.xpviewSuppliersProduct.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Supplier", DevExpress.Xpo.SortDirection.Ascending, "[CompanyName]", false, true),
            new DevExpress.Xpo.ViewProperty("Product Count", DevExpress.Xpo.SortDirection.None, "[Products][].Count()", false, true),
            new DevExpress.Xpo.ViewProperty("Contact", DevExpress.Xpo.SortDirection.None, "\'<\' + [ContactTitle] + \'> \' + [ContactName]", false, true)});
            this.xpviewSuppliersProduct.Session = this.session1;
            this.xpviewSuppliersProduct.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[Product Count]", DevExpress.Xpo.DB.SortingDirection.Descending)});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbViews);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 38);
            this.panel1.TabIndex = 1;
            // 
            // cbViews
            // 
            this.cbViews.Location = new System.Drawing.Point(68, 8);
            this.cbViews.Name = "cbViews";
            this.cbViews.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbViews.Properties.Items.AddRange(new object[] {
            "Products",
            "Products for Supplier",
            "Orders"});
            this.cbViews.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbViews.Size = new System.Drawing.Size(224, 20);
            this.cbViews.TabIndex = 1;
            this.cbViews.SelectedIndexChanged += new System.EventHandler(this.cbViews_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Views: ";
            // 
            // xpviewProducts
            // 
            this.xpviewProducts.ObjectType = typeof(DevExpress.Xpo.Demos.Tutorials.Products);
            this.xpviewProducts.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Name", DevExpress.Xpo.SortDirection.Ascending, "[ProductName]", false, true),
            new DevExpress.Xpo.ViewProperty("Category", DevExpress.Xpo.SortDirection.None, "[CategoryID.CategoryName]", false, true)});
            this.xpviewProducts.Session = this.session1;
            // 
            // xpviewOrders
            // 
            this.xpviewOrders.ObjectType = typeof(DevExpress.Xpo.Demos.Tutorials.Orders);
            this.xpviewOrders.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Order", DevExpress.Xpo.SortDirection.None, "[OrderID]", false, true),
            new DevExpress.Xpo.ViewProperty("Details Count", DevExpress.Xpo.SortDirection.None, "[OrderDetails][].Count()", false, true),
            new DevExpress.Xpo.ViewProperty("Order Amount", DevExpress.Xpo.SortDirection.None, "[OrderDetails][].Sum([UnitPrice] * [Quantity] * (1 - [Discount]))", false, true),
            new DevExpress.Xpo.ViewProperty("Employee", DevExpress.Xpo.SortDirection.None, "[EmployeeID.FirstName] + \' \' + [EmployeeID.LastName]", false, true),
            new DevExpress.Xpo.ViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[CustomerID.CompanyName]", false, true)});
            this.xpviewOrders.Session = this.session1;
            this.xpviewOrders.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[Order Amount]", DevExpress.Xpo.DB.SortingDirection.Descending)});
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(609, 276);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BestFitMaxRowCount = 100;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 46);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(613, 300);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 38);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(613, 8);
            this.panelControl2.TabIndex = 5;
            // 
            // XPViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panel1);
            this.Name = "XPViewDemo";
            this.Size = new System.Drawing.Size(613, 346);
            this.Load += new System.EventHandler(this.XPViewDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpviewSuppliersProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbViews.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpviewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpviewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.XPView xpviewSuppliersProduct;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbViews;
        private DevExpress.Xpo.XPView xpviewProducts;
        private DevExpress.Xpo.XPView xpviewOrders;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.Session session1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.ComponentModel.IContainer components;

    }
}
